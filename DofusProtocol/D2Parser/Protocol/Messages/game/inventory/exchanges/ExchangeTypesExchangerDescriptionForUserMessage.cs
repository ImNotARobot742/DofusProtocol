

// Generated on 06/13/2023 16:59:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeTypesExchangerDescriptionForUserMessage : NetworkMessage
    {
        public const uint Id = 7587;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int objectType;
        public uint[] typeDescription;
        
        public ExchangeTypesExchangerDescriptionForUserMessage()
        {
        }
        
        public ExchangeTypesExchangerDescriptionForUserMessage(int objectType, uint[] typeDescription)
        {
            this.objectType = objectType;
            this.typeDescription = typeDescription;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(objectType);
            writer.WriteShort((short)typeDescription.Length);
            foreach (var entry in typeDescription)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectType = reader.ReadInt();
            var limit = (ushort)reader.ReadUShort();
            typeDescription = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 typeDescription[i] = reader.ReadVarUInt();
            }
        }
        
    }
    
}