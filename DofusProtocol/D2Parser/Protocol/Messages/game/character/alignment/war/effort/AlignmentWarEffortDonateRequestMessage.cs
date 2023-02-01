

// Generated on 02/01/2023 12:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AlignmentWarEffortDonateRequestMessage : NetworkMessage
    {
        public const uint Id = 6956;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double donation;
        
        public AlignmentWarEffortDonateRequestMessage()
        {
        }
        
        public AlignmentWarEffortDonateRequestMessage(double donation)
        {
            this.donation = donation;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(donation);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            donation = reader.ReadVarULong();
        }
        
    }
    
}