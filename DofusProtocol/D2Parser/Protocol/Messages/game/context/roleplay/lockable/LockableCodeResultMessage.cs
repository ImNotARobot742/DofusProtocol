

// Generated on 06/13/2023 16:59:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LockableCodeResultMessage : NetworkMessage
    {
        public const uint Id = 6533;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte result;
        
        public LockableCodeResultMessage()
        {
        }
        
        public LockableCodeResultMessage(sbyte result)
        {
            this.result = result;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(result);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            result = reader.ReadSbyte();
        }
        
    }
    
}