

// Generated on 05/18/2023 15:10:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LockableUseCodeMessage : NetworkMessage
    {
        public const uint Id = 2127;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string code;
        
        public LockableUseCodeMessage()
        {
        }
        
        public LockableUseCodeMessage(string code)
        {
            this.code = code;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(code);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            code = reader.ReadUTF();
        }
        
    }
    
}