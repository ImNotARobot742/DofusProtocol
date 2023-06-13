

// Generated on 06/13/2023 16:59:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayAggressionMessage : NetworkMessage
    {
        public const uint Id = 1747;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double attackerId;
        public double defenderId;
        
        public GameRolePlayAggressionMessage()
        {
        }
        
        public GameRolePlayAggressionMessage(double attackerId, double defenderId)
        {
            this.attackerId = attackerId;
            this.defenderId = defenderId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(attackerId);
            writer.WriteVarLong(defenderId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            attackerId = reader.ReadVarULong();
            defenderId = reader.ReadVarULong();
        }
        
    }
    
}