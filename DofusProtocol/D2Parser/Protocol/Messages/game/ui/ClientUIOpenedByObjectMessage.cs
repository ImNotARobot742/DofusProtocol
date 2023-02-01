

// Generated on 02/01/2023 12:53:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ClientUIOpenedByObjectMessage : ClientUIOpenedMessage
    {
        public const uint Id = 9520;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint uid;
        
        public ClientUIOpenedByObjectMessage()
        {
        }
        
        public ClientUIOpenedByObjectMessage(sbyte type, uint uid)
         : base(type)
        {
            this.uid = uid;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)uid);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            uid = reader.ReadVarUInt();
        }
        
    }
    
}