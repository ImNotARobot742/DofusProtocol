

// Generated on 01/01/2022 14:39:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectQuantityMessage : NetworkMessage
    {
        public const uint Id = 80;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectUID;
        public uint quantity;
        public sbyte origin;
        
        public ObjectQuantityMessage()
        {
        }
        
        public ObjectQuantityMessage(uint objectUID, uint quantity, sbyte origin)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
            this.origin = origin;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            writer.WriteSbyte(origin);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectUID = reader.ReadVarUInt();
            quantity = reader.ReadVarUInt();
            origin = reader.ReadSbyte();
        }
        
    }
    
}