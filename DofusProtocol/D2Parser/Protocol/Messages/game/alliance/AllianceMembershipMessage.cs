

// Generated on 02/01/2023 12:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceMembershipMessage : AllianceJoinedMessage
    {
        public const uint Id = 4163;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public AllianceMembershipMessage()
        {
        }
        
        public AllianceMembershipMessage(Types.AllianceInformations allianceInfo, bool enabled, uint leadingGuildId)
         : base(allianceInfo, enabled, leadingGuildId)
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