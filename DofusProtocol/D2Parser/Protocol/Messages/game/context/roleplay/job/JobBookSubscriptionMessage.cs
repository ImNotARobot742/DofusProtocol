

// Generated on 01/01/2022 14:39:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class JobBookSubscriptionMessage : NetworkMessage
    {
        public const uint Id = 8266;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.JobBookSubscription[] subscriptions;
        
        public JobBookSubscriptionMessage()
        {
        }
        
        public JobBookSubscriptionMessage(Types.JobBookSubscription[] subscriptions)
        {
            this.subscriptions = subscriptions;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)subscriptions.Length);
            foreach (var entry in subscriptions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            subscriptions = new Types.JobBookSubscription[limit];
            for (int i = 0; i < limit; i++)
            {
                 subscriptions[i] = new Types.JobBookSubscription();
                 subscriptions[i].Deserialize(reader);
            }
        }
        
    }
    
}