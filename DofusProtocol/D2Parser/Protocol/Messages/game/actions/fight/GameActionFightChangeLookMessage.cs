

// Generated on 01/01/2022 14:39:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightChangeLookMessage : AbstractGameActionMessage
    {
        public const uint Id = 4039;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        public Types.EntityLook entityLook;
        
        public GameActionFightChangeLookMessage()
        {
        }
        
        public GameActionFightChangeLookMessage(uint actionId, double sourceId, double targetId, Types.EntityLook entityLook)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.entityLook = entityLook;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            entityLook.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
        }
        
    }
    
}