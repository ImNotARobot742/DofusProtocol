

// Generated on 03/23/2022 09:50:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ShortcutBarSwapErrorMessage : NetworkMessage
    {
        public const uint Id = 9976;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte error;
        
        public ShortcutBarSwapErrorMessage()
        {
        }
        
        public ShortcutBarSwapErrorMessage(sbyte error)
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