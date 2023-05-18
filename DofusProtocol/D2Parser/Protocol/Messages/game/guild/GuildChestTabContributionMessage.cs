

// Generated on 05/18/2023 16:28:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildChestTabContributionMessage : NetworkMessage
    {
        public const uint Id = 8798;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint tabNumber;
        public double requiredAmount;
        public double currentAmount;
        public double chestContributionEnrollmentDelay;
        public double chestContributionDelay;
        
        public GuildChestTabContributionMessage()
        {
        }
        
        public GuildChestTabContributionMessage(uint tabNumber, double requiredAmount, double currentAmount, double chestContributionEnrollmentDelay, double chestContributionDelay)
        {
            this.tabNumber = tabNumber;
            this.requiredAmount = requiredAmount;
            this.currentAmount = currentAmount;
            this.chestContributionEnrollmentDelay = chestContributionEnrollmentDelay;
            this.chestContributionDelay = chestContributionDelay;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)tabNumber);
            writer.WriteVarLong(requiredAmount);
            writer.WriteVarLong(currentAmount);
            writer.WriteDouble(chestContributionEnrollmentDelay);
            writer.WriteDouble(chestContributionDelay);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            tabNumber = reader.ReadVarUInt();
            requiredAmount = reader.ReadVarULong();
            currentAmount = reader.ReadVarULong();
            chestContributionEnrollmentDelay = reader.ReadDouble();
            chestContributionDelay = reader.ReadDouble();
        }
        
    }
    
}