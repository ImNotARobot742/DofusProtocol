

// Generated on 06/13/2023 16:59:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterAlignmentWarEffortProgressionMessage : NetworkMessage
    {
        public const uint Id = 34;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double alignmentWarEffortDailyLimit;
        public double alignmentWarEffortDailyDonation;
        public double alignmentWarEffortPersonalDonation;
        
        public CharacterAlignmentWarEffortProgressionMessage()
        {
        }
        
        public CharacterAlignmentWarEffortProgressionMessage(double alignmentWarEffortDailyLimit, double alignmentWarEffortDailyDonation, double alignmentWarEffortPersonalDonation)
        {
            this.alignmentWarEffortDailyLimit = alignmentWarEffortDailyLimit;
            this.alignmentWarEffortDailyDonation = alignmentWarEffortDailyDonation;
            this.alignmentWarEffortPersonalDonation = alignmentWarEffortPersonalDonation;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(alignmentWarEffortDailyLimit);
            writer.WriteVarLong(alignmentWarEffortDailyDonation);
            writer.WriteVarLong(alignmentWarEffortPersonalDonation);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            alignmentWarEffortDailyLimit = reader.ReadVarULong();
            alignmentWarEffortDailyDonation = reader.ReadVarULong();
            alignmentWarEffortPersonalDonation = reader.ReadVarULong();
        }
        
    }
    
}