

// Generated on 03/23/2022 09:50:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightLifeAndShieldPointsLostMessage : GameActionFightLifePointsLostMessage
    {
        public const uint Id = 894;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint shieldLoss;
        
        public GameActionFightLifeAndShieldPointsLostMessage()
        {
        }
        
        public GameActionFightLifeAndShieldPointsLostMessage(uint actionId, double sourceId, double targetId, uint loss, uint permanentDamages, int elementId, uint shieldLoss)
         : base(actionId, sourceId, targetId, loss, permanentDamages, elementId)
        {
            this.shieldLoss = shieldLoss;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)shieldLoss);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            shieldLoss = reader.ReadVarUShort();
        }
        
    }
    
}