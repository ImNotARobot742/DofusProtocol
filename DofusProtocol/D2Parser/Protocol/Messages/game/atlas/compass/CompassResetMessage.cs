

// Generated on 03/23/2022 09:50:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CompassResetMessage : NetworkMessage
    {
        public const uint Id = 8958;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte type;
        
        public CompassResetMessage()
        {
        }
        
        public CompassResetMessage(sbyte type)
        {
            this.type = type;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(type);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            type = reader.ReadSbyte();
        }
        
    }
    
}