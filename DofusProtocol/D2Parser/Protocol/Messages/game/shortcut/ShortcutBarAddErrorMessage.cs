

// Generated on 05/18/2023 16:29:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ShortcutBarAddErrorMessage : NetworkMessage
    {
        public const uint Id = 406;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte error;
        
        public ShortcutBarAddErrorMessage()
        {
        }
        
        public ShortcutBarAddErrorMessage(sbyte error)
        {
            this.error = error;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(error);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            error = reader.ReadSbyte();
        }
        
    }
    
}