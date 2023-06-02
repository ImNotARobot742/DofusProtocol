

// Generated on 06/02/2023 19:00:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeStartedWithMultiTabStorageMessage : ExchangeStartedMessage
    {
        public const uint Id = 3800;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint storageMaxSlot;
        public uint tabNumber;
        
        public ExchangeStartedWithMultiTabStorageMessage()
        {
        }
        
        public ExchangeStartedWithMultiTabStorageMessage(sbyte exchangeType, uint storageMaxSlot, uint tabNumber)
         : base(exchangeType)
        {
            this.storageMaxSlot = storageMaxSlot;
            this.tabNumber = tabNumber;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)storageMaxSlot);
            writer.WriteVarInt((int)tabNumber);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            storageMaxSlot = reader.ReadVarUInt();
            tabNumber = reader.ReadVarUInt();
        }
        
    }
    
}