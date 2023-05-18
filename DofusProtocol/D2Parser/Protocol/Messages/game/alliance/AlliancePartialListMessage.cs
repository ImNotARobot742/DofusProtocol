

// Generated on 05/18/2023 15:10:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AlliancePartialListMessage : AllianceListMessage
    {
        public const uint Id = 8827;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public AlliancePartialListMessage()
        {
        }
        
        public AlliancePartialListMessage(Types.AllianceFactSheetInformations[] alliances)
         : base(alliances)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}