

// Generated on 06/02/2023 19:00:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildInfosUpgradeMessage : NetworkMessage
    {
        public const uint Id = 1989;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte maxTaxCollectorsCount;
        public sbyte taxCollectorsCount;
        public uint taxCollectorLifePoints;
        public uint taxCollectorDamagesBonuses;
        public uint taxCollectorPods;
        public uint taxCollectorProspecting;
        public uint taxCollectorWisdom;
        public uint boostPoints;
        public uint[] spellId;
        public short[] spellLevel;
        
        public GuildInfosUpgradeMessage()
        {
        }
        
        public GuildInfosUpgradeMessage(sbyte maxTaxCollectorsCount, sbyte taxCollectorsCount, uint taxCollectorLifePoints, uint taxCollectorDamagesBonuses, uint taxCollectorPods, uint taxCollectorProspecting, uint taxCollectorWisdom, uint boostPoints, uint[] spellId, short[] spellLevel)
        {
            this.maxTaxCollectorsCount = maxTaxCollectorsCount;
            this.taxCollectorsCount = taxCollectorsCount;
            this.taxCollectorLifePoints = taxCollectorLifePoints;
            this.taxCollectorDamagesBonuses = taxCollectorDamagesBonuses;
            this.taxCollectorPods = taxCollectorPods;
            this.taxCollectorProspecting = taxCollectorProspecting;
            this.taxCollectorWisdom = taxCollectorWisdom;
            this.boostPoints = boostPoints;
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(maxTaxCollectorsCount);
            writer.WriteSbyte(taxCollectorsCount);
            writer.WriteVarShort((short)taxCollectorLifePoints);
            writer.WriteVarShort((short)taxCollectorDamagesBonuses);
            writer.WriteVarShort((short)taxCollectorPods);
            writer.WriteVarShort((short)taxCollectorProspecting);
            writer.WriteVarShort((short)taxCollectorWisdom);
            writer.WriteVarShort((short)boostPoints);
            writer.WriteShort((short)spellId.Length);
            foreach (var entry in spellId)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteShort((short)spellLevel.Length);
            foreach (var entry in spellLevel)
            {
                 writer.WriteShort(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            maxTaxCollectorsCount = reader.ReadSbyte();
            taxCollectorsCount = reader.ReadSbyte();
            taxCollectorLifePoints = reader.ReadVarUShort();
            taxCollectorDamagesBonuses = reader.ReadVarUShort();
            taxCollectorPods = reader.ReadVarUShort();
            taxCollectorProspecting = reader.ReadVarUShort();
            taxCollectorWisdom = reader.ReadVarUShort();
            boostPoints = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            spellId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 spellId[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadUShort();
            spellLevel = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 spellLevel[i] = reader.ReadShort();
            }
        }
        
    }
    
}