

// Generated on 01/01/2022 14:39:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightPointsVariationMessage : AbstractGameActionMessage
    {
        public const uint Id = 7694;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        public short delta;
        
        public GameActionFightPointsVariationMessage()
        {
        }
        
        public GameActionFightPointsVariationMessage(uint actionId, double sourceId, double targetId, short delta)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.delta = delta;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteShort(delta);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            delta = reader.ReadShort();
        }
        
    }
    
}