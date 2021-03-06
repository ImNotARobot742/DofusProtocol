

// Generated on 03/23/2022 09:51:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ObjectItemGenericQuantity : Item
    {
        public const short Id = 2677;
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