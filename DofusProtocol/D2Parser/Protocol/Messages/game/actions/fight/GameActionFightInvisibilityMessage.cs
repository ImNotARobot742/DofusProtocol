

// Generated on 05/18/2023 16:28:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightInvisibilityMessage : AbstractGameActionMessage
    {
        public const uint Id = 6061;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        public sbyte state;
        
        public GameActionFightInvisibilityMessage()
        {
        }
        
        public GameActionFightInvisibilityMessage(uint actionId, double sourceId, double targetId, sbyte state)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.state = state;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteSbyte(state);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            state = reader.ReadSbyte();
        }
        
    }
    
}