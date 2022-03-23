

// Generated on 03/23/2022 09:50:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightDodgePointLossMessage : AbstractGameActionMessage
    {
        public const uint Id = 948;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        public uint amount;
        
        public GameActionFightDodgePointLossMessage()
        {
        }
        
        public GameActionFightDodgePointLossMessage(uint actionId, double sourceId, double targetId, uint amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarShort((short)amount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            amount = reader.ReadVarUShort();
        }
        
    }
    
}