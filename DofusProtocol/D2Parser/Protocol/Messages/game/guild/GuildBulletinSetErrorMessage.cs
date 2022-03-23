

// Generated on 03/23/2022 09:50:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildBulletinSetErrorMessage : SocialNoticeSetErrorMessage
    {
        public const uint Id = 4748;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public GuildBulletinSetErrorMessage()
        {
        }
        
        public GuildBulletinSetErrorMessage(sbyte reason)
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