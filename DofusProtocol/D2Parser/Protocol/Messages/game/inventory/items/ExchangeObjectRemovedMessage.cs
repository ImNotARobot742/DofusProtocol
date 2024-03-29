

// Generated on 06/13/2023 16:59:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeObjectRemovedMessage : ExchangeObjectMessage
    {
        public const uint Id = 5821;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectUID;
        
        public ExchangeObjectRemovedMessage()
        {
        }
        
        public ExchangeObjectRemovedMessage(bool remote, uint objectUID)
         : base(remote)
        {
            this.objectUID = objectUID;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)objectUID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            objectUID = reader.ReadVarUInt();
        }
        
    }
    
}