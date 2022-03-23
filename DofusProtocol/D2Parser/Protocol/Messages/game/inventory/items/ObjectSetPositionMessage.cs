

// Generated on 03/23/2022 09:50:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectSetPositionMessage : NetworkMessage
    {
        public const uint Id = 1022;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectUID;
        public short position;
        public uint quantity;
        
        public ObjectSetPositionMessage()
        {
        }
        
        public ObjectSetPositionMessage(uint objectUID, short position, uint quantity)
        {
            this.objectUID = objectUID;
            this.position = position;
            this.quantity = quantity;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteShort(position);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectUID = reader.ReadVarUInt();
            position = reader.ReadShort();
            quantity = reader.ReadVarUInt();
        }
        
    }
    
}