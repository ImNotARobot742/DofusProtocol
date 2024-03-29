

// Generated on 06/13/2023 17:00:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ObjectItemToSellInHumanVendorShop : Item
    {
        public const short Id = 4724;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint objectGID;
        public Types.ObjectEffect[] effects;
        public uint objectUID;
        public uint quantity;
        public double objectPrice;
        public double publicPrice;
        
        public ObjectItemToSellInHumanVendorShop()
        {
        }
        
        public ObjectItemToSellInHumanVendorShop(uint objectGID, Types.ObjectEffect[] effects, uint objectUID, uint quantity, double objectPrice, double publicPrice)
        {
            this.objectGID = objectGID;
            this.effects = effects;
            this.objectUID = objectUID;
            this.quantity = quantity;
            this.objectPrice = objectPrice;
            this.publicPrice = publicPrice;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)objectGID);
            writer.WriteShort((short)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            writer.WriteVarLong(objectPrice);
            writer.WriteVarLong(publicPrice);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            objectGID = reader.ReadVarUInt();
            var limit = (ushort)reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadUShort());
                 effects[i].Deserialize(reader);
            }
            objectUID = reader.ReadVarUInt();
            quantity = reader.ReadVarUInt();
            objectPrice = reader.ReadVarULong();
            publicPrice = reader.ReadVarULong();
        }
        
    }
    
}