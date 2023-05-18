

// Generated on 05/18/2023 16:28:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightKillMessage : AbstractGameActionMessage
    {
        public const uint Id = 5884;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        
        public GameActionFightKillMessage()
        {
        }
        
        public GameActionFightKillMessage(uint actionId, double sourceId, double targetId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
        }
        
    }
    
}