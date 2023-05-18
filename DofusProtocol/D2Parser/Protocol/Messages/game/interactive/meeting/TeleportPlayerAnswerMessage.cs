

// Generated on 05/18/2023 15:10:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TeleportPlayerAnswerMessage : NetworkMessage
    {
        public const uint Id = 4498;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool accept;
        public double requesterId;
        
        public TeleportPlayerAnswerMessage()
        {
        }
        
        public TeleportPlayerAnswerMessage(bool accept, double requesterId)
        {
            this.accept = accept;
            this.requesterId = requesterId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(accept);
            writer.WriteVarLong(requesterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            accept = reader.ReadBoolean();
            requesterId = reader.ReadVarULong();
        }
        
    }
    
}