

// Generated on 05/18/2023 16:29:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class StartupActionAddObject
    {
        public const short Id = 4737;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int uid;
        public string title;
        public string text;
        public string descUrl;
        public string pictureUrl;
        public Types.ObjectItemInformationWithQuantity[] items;
        public uint type;
        
        public StartupActionAddObject()
        {
        }
        
        public StartupActionAddObject(int uid, string title, string text, string descUrl, string pictureUrl, Types.ObjectItemInformationWithQuantity[] items, uint type)
        {
            this.uid = uid;
            this.title = title;
            this.text = text;
            this.descUrl = descUrl;
            this.pictureUrl = pictureUrl;
            this.items = items;
            this.type = type;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(uid);
            writer.WriteUTF(title);
            writer.WriteUTF(text);
            writer.WriteUTF(descUrl);
            writer.WriteUTF(pictureUrl);
            writer.WriteShort((short)items.Length);
            foreach (var entry in items)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarInt((int)type);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            uid = reader.ReadInt();
            title = reader.ReadUTF();
            text = reader.ReadUTF();
            descUrl = reader.ReadUTF();
            pictureUrl = reader.ReadUTF();
            var limit = (ushort)reader.ReadUShort();
            items = new Types.ObjectItemInformationWithQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 items[i] = new Types.ObjectItemInformationWithQuantity();
                 items[i].Deserialize(reader);
            }
            type = reader.ReadVarUInt();
        }
        
    }
    
}