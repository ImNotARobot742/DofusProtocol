

// Generated on 05/18/2023 16:29:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class DecraftedItemStackInfo
    {
        public const short Id = 1461;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint objectUID;
        public double bonusMin;
        public double bonusMax;
        public uint[] runesId;
        public uint[] runesQty;
        
        public DecraftedItemStackInfo()
        {
        }
        
        public DecraftedItemStackInfo(uint objectUID, double bonusMin, double bonusMax, uint[] runesId, uint[] runesQty)
        {
            this.objectUID = objectUID;
            this.bonusMin = bonusMin;
            this.bonusMax = bonusMax;
            this.runesId = runesId;
            this.runesQty = runesQty;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteDouble(bonusMin);
            writer.WriteDouble(bonusMax);
            writer.WriteShort((short)runesId.Length);
            foreach (var entry in runesId)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)runesQty.Length);
            foreach (var entry in runesQty)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            objectUID = reader.ReadVarUInt();
            bonusMin = reader.ReadDouble();
            bonusMax = reader.ReadDouble();
            var limit = (ushort)reader.ReadUShort();
            runesId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 runesId[i] = reader.ReadVarUInt();
            }
            limit = (ushort)reader.ReadUShort();
            runesQty = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 runesQty[i] = reader.ReadVarUInt();
            }
        }
        
    }
    
}