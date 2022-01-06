

// Generated on 01/01/2022 14:39:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatAbstractServerMessage : NetworkMessage
    {
        public const uint Id = 3393;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte channel;
        public string content;
        public int timestamp;
        public string fingerprint;
        
        public ChatAbstractServerMessage()
        {
        }
        
        public ChatAbstractServerMessage(sbyte channel, string content, int timestamp, string fingerprint)
        {
            this.channel = channel;
            this.content = content;
            this.timestamp = timestamp;
            this.fingerprint = fingerprint;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(channel);
            writer.WriteUTF(content);
            writer.WriteInt(timestamp);
            writer.WriteUTF(fingerprint);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            channel = reader.ReadSbyte();
            content = reader.ReadUTF();
            timestamp = reader.ReadInt();
            fingerprint = reader.ReadUTF();
        }
        
    }
    
}