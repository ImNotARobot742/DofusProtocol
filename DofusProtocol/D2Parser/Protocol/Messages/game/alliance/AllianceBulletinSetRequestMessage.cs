

// Generated on 03/23/2022 09:50:12
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceBulletinSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public const uint Id = 8339;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string content;
        public bool notifyMembers;
        
        public AllianceBulletinSetRequestMessage()
        {
        }
        
        public AllianceBulletinSetRequestMessage(string content, bool notifyMembers)
        {
            this.content = content;
            this.notifyMembers = notifyMembers;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(content);
            writer.WriteBoolean(notifyMembers);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            content = reader.ReadUTF();
            notifyMembers = reader.ReadBoolean();
        }
        
    }
    
}