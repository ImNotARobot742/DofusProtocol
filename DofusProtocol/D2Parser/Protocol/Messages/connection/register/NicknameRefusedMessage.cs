

// Generated on 01/01/2022 14:39:08
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
        public const uint Id = 2705;
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