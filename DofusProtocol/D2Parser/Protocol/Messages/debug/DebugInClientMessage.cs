

// Generated on 05/18/2023 16:28:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DebugInClientMessage : NetworkMessage
    {
        public const uint Id = 1039;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte level;
        public string message;
        
        public DebugInClientMessage()
        {
        }
        
        public DebugInClientMessage(sbyte level, string message)
        {
            this.level = level;
            this.message = message;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(level);
            writer.WriteUTF(message);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            level = reader.ReadSbyte();
            message = reader.ReadUTF();
        }
        
    }
    
}