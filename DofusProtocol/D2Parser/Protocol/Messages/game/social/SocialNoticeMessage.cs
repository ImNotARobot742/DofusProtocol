

// Generated on 05/18/2023 15:10:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SocialNoticeMessage : NetworkMessage
    {
        public const uint Id = 3739;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string content;
        public int timestamp;
        public double memberId;
        public string memberName;
        
        public SocialNoticeMessage()
        {
        }
        
        public SocialNoticeMessage(string content, int timestamp, double memberId, string memberName)
        {
            this.content = content;
            this.timestamp = timestamp;
            this.memberId = memberId;
            this.memberName = memberName;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(content);
            writer.WriteInt(timestamp);
            writer.WriteVarLong(memberId);
            writer.WriteUTF(memberName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            content = reader.ReadUTF();
            timestamp = reader.ReadInt();
            memberId = reader.ReadVarULong();
            memberName = reader.ReadUTF();
        }
        
    }
    
}