

// Generated on 01/01/2022 14:39:12
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightStealKamaMessage : AbstractGameActionMessage
    {
        public const uint Id = 8847;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        public double amount;
        
        public GameActionFightStealKamaMessage()
        {
        }
        
        public GameActionFightStealKamaMessage(uint actionId, double sourceId, double targetId, double amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarLong(amount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            amount = reader.ReadVarULong();
        }
        
    }
    
}