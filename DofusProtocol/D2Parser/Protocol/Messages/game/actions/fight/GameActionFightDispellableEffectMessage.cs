

// Generated on 06/13/2023 16:59:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightDispellableEffectMessage : AbstractGameActionMessage
    {
        public const uint Id = 4830;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AbstractFightDispellableEffect effect;
        
        public GameActionFightDispellableEffectMessage()
        {
        }
        
        public GameActionFightDispellableEffectMessage(uint actionId, double sourceId, Types.AbstractFightDispellableEffect effect)
         : base(actionId, sourceId)
        {
            this.effect = effect;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(effect.TypeId);
            effect.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            effect = ProtocolTypeManager.GetInstance<Types.AbstractFightDispellableEffect>(reader.ReadUShort());
            effect.Deserialize(reader);
        }
        
    }
    
}