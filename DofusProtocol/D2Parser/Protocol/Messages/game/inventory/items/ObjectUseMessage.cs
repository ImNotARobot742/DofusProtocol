

// Generated on 05/18/2023 16:29:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectUseMessage : NetworkMessage
    {
        public const uint Id = 7313;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectUID;
        
        public ObjectUseMessage()
        {
        }
        
        public ObjectUseMessage(uint objectUID)
        {
            this.objectUID = objectUID;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectUID = reader.ReadVarUInt();
        }
        
    }
    
}