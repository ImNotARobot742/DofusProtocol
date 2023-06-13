

// Generated on 06/13/2023 17:00:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TaxCollectorLootInformations : TaxCollectorComplementaryInformations
    {
        public const short Id = 6864;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double kamas;
        public double experience;
        public uint pods;
        public double itemsValue;
        
        public TaxCollectorLootInformations()
        {
        }
        
        public TaxCollectorLootInformations(double kamas, double experience, uint pods, double itemsValue)
        {
            this.kamas = kamas;
            this.experience = experience;
            this.pods = pods;
            this.itemsValue = itemsValue;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(kamas);
            writer.WriteVarLong(experience);
            writer.WriteVarInt((int)pods);
            writer.WriteVarLong(itemsValue);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            kamas = reader.ReadVarULong();
            experience = reader.ReadVarULong();
            pods = reader.ReadVarUInt();
            itemsValue = reader.ReadVarULong();
        }
        
    }
    
}