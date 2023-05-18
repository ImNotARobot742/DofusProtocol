

// Generated on 05/18/2023 15:11:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ItemForPreset
    {
        public const short Id = 5749;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public short position;
        public uint objGid;
        public uint objUid;
        
        public ItemForPreset()
        {
        }
        
        public ItemForPreset(short position, uint objGid, uint objUid)
        {
            this.position = position;
            this.objGid = objGid;
            this.objUid = objUid;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort(position);
            writer.WriteVarInt((int)objGid);
            writer.WriteVarInt((int)objUid);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            position = reader.ReadShort();
            objGid = reader.ReadVarUInt();
            objUid = reader.ReadVarUInt();
        }
        
    }
    
}