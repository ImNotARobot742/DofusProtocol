

// Generated on 01/01/2022 14:39:50
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
        public const uint Id = 3065;
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