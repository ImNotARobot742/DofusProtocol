

// Generated on 01/01/2022 14:39:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiValidationMessage : NetworkMessage
    {
        public const uint Id = 8710;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte action;
        public sbyte code;
        
        public HaapiValidationMessage()
        {
        }
        
        public HaapiValidationMessage(sbyte action, sbyte code)
        {
            this.action = action;
            this.code = code;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(action);
            writer.WriteSbyte(code);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            action = reader.ReadSbyte();
            code = reader.ReadSbyte();
        }
        
    }
    
}