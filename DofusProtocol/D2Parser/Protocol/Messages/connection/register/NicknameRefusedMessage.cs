

// Generated on 02/01/2023 12:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class NicknameRefusedMessage : NetworkMessage
    {
        public const uint Id = 7996;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        
        public NicknameRefusedMessage()
        {
        }
        
        public NicknameRefusedMessage(sbyte reason)
        {
            this.reason = reason;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            reason = reader.ReadSbyte();
        }
        
    }
    
}