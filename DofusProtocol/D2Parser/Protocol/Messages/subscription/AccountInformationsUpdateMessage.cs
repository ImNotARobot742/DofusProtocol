

// Generated on 06/02/2023 19:00:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AccountInformationsUpdateMessage : NetworkMessage
    {
        public const uint Id = 8141;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double subscriptionEndDate;
        
        public AccountInformationsUpdateMessage()
        {
        }
        
        public AccountInformationsUpdateMessage(double subscriptionEndDate)
        {
            this.subscriptionEndDate = subscriptionEndDate;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(subscriptionEndDate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            subscriptionEndDate = reader.ReadDouble();
        }
        
    }
    
}