

// Generated on 01/01/2022 14:40:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ObjectItemGenericQuantity : Item
    {
        public const short Id = 7873;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint objectGID;
        public uint quantity;
        
        public ObjectItemGenericQuantity()
        {
        }
        
        public ObjectItemGenericQuantity(uint objectGID, uint quantity)
        {
            this.objectGID = objectGID;
            this.quantity = quantity;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)objectGID);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            objectGID = reader.ReadVarUShort();
            quantity = reader.ReadVarUInt();
        }
        
    }
    
}