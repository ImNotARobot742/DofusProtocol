

// Generated on 05/18/2023 15:10:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SetUpdateMessage : NetworkMessage
    {
        public const uint Id = 9543;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint setId;
        public uint[] setObjects;
        public Types.ObjectEffect[] setEffects;
        
        public SetUpdateMessage()
        {
        }
        
        public SetUpdateMessage(uint setId, uint[] setObjects, Types.ObjectEffect[] setEffects)
        {
            this.setId = setId;
            this.setObjects = setObjects;
            this.setEffects = setEffects;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)setId);
            writer.WriteShort((short)setObjects.Length);
            foreach (var entry in setObjects)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)setEffects.Length);
            foreach (var entry in setEffects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            setId = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            setObjects = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 setObjects[i] = reader.ReadVarUInt();
            }
            limit = (ushort)reader.ReadUShort();
            setEffects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 setEffects[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadUShort());
                 setEffects[i].Deserialize(reader);
            }
        }
        
    }
    
}