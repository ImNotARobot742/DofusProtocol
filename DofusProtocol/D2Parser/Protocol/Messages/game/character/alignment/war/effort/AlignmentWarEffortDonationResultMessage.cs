

// Generated on 03/23/2022 09:50:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AlignmentWarEffortDonationResultMessage : NetworkMessage
    {
        public const uint Id = 9607;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte result;
        
        public AlignmentWarEffortDonationResultMessage()
        {
        }
        
        public AlignmentWarEffortDonationResultMessage(sbyte result)
        {
            this.result = result;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(result);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            result = reader.ReadSbyte();
        }
        
    }
    
}