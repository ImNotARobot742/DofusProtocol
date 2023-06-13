

// Generated on 06/13/2023 16:59:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectUseMultipleMessage : ObjectUseMessage
    {
        public const uint Id = 2511;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint quantity;
        
        public ObjectUseMultipleMessage()
        {
        }
        
        public ObjectUseMultipleMessage(uint objectUID, uint quantity)
         : base(objectUID)
        {
            this.quantity = quantity;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            quantity = reader.ReadVarUInt();
        }
        
    }
    
}