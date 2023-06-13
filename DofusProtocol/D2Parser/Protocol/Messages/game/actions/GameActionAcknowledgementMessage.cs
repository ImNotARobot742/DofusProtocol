

// Generated on 06/13/2023 16:59:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionAcknowledgementMessage : NetworkMessage
    {
        public const uint Id = 8025;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool valid;
        public sbyte actionId;
        
        public GameActionAcknowledgementMessage()
        {
        }
        
        public GameActionAcknowledgementMessage(bool valid, sbyte actionId)
        {
            this.valid = valid;
            this.actionId = actionId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(valid);
            writer.WriteSbyte(actionId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            valid = reader.ReadBoolean();
            actionId = reader.ReadSbyte();
        }
        
    }
    
}