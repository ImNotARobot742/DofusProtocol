

// Generated on 05/18/2023 15:10:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeStartOkMulticraftCustomerMessage : NetworkMessage
    {
        public const uint Id = 9647;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint skillId;
        public byte crafterJobLevel;
        
        public ExchangeStartOkMulticraftCustomerMessage()
        {
        }
        
        public ExchangeStartOkMulticraftCustomerMessage(uint skillId, byte crafterJobLevel)
        {
            this.skillId = skillId;
            this.crafterJobLevel = crafterJobLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)skillId);
            writer.WriteByte(crafterJobLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            skillId = reader.ReadVarUInt();
            crafterJobLevel = reader.ReadByte();
        }
        
    }
    
}