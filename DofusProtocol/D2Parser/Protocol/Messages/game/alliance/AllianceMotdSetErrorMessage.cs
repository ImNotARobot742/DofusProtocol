

// Generated on 02/01/2023 12:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceMotdSetErrorMessage : SocialNoticeSetErrorMessage
    {
        public const uint Id = 2004;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public AllianceMotdSetErrorMessage()
        {
        }
        
        public AllianceMotdSetErrorMessage(sbyte reason)
         : base(reason)
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