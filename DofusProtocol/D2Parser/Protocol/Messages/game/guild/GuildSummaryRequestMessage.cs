

// Generated on 05/18/2023 15:10:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildSummaryRequestMessage : PaginationRequestAbstractMessage
    {
        public const uint Id = 3167;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool hideFullFilter;
        public bool sortDescending;
        public string nameFilter;
        public uint[] criterionFilter;
        public uint[] languagesFilter;
        public sbyte[] recruitmentTypeFilter;
        public short minLevelFilter;
        public short maxLevelFilter;
        public short minPlayerLevelFilter;
        public short maxPlayerLevelFilter;
        public uint minSuccessFilter;
        public uint maxSuccessFilter;
        public sbyte sortType;
        
        public GuildSummaryRequestMessage()
        {
        }
        
        public GuildSummaryRequestMessage(double offset, uint count, bool hideFullFilter, bool sortDescending, string nameFilter, uint[] criterionFilter, uint[] languagesFilter, sbyte[] recruitmentTypeFilter, short minLevelFilter, short maxLevelFilter, short minPlayerLevelFilter, short maxPlayerLevelFilter, uint minSuccessFilter, uint maxSuccessFilter, sbyte sortType)
         : base(offset, count)
        {
            this.hideFullFilter = hideFullFilter;
            this.sortDescending = sortDescending;
            this.nameFilter = nameFilter;
            this.criterionFilter = criterionFilter;
            this.languagesFilter = languagesFilter;
            this.recruitmentTypeFilter = recruitmentTypeFilter;
            this.minLevelFilter = minLevelFilter;
            this.maxLevelFilter = maxLevelFilter;
            this.minPlayerLevelFilter = minPlayerLevelFilter;
            this.maxPlayerLevelFilter = maxPlayerLevelFilter;
            this.minSuccessFilter = minSuccessFilter;
            this.maxSuccessFilter = maxSuccessFilter;
            this.sortType = sortType;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, hideFullFilter);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, sortDescending);
            writer.WriteByte(flag1);
            writer.WriteUTF(nameFilter);
            writer.WriteShort((short)criterionFilter.Length);
            foreach (var entry in criterionFilter)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)languagesFilter.Length);
            foreach (var entry in languagesFilter)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteVarInt((int)(ushort)recruitmentTypeFilter.Length);
            foreach (var entry in recruitmentTypeFilter)
            {
                 writer.WriteSbyte(entry);
            }
            writer.WriteShort(minLevelFilter);
            writer.WriteShort(maxLevelFilter);
            writer.WriteShort(minPlayerLevelFilter);
            writer.WriteShort(maxPlayerLevelFilter);
            writer.WriteVarInt((int)minSuccessFilter);
            writer.WriteVarInt((int)maxSuccessFilter);
            writer.WriteSbyte(sortType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            hideFullFilter = BooleanByteWrapper.GetFlag(flag1, 0);
            sortDescending = BooleanByteWrapper.GetFlag(flag1, 1);
            nameFilter = reader.ReadUTF();
            var limit = (ushort)reader.ReadUShort();
            criterionFilter = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 criterionFilter[i] = reader.ReadVarUInt();
            }
            limit = (ushort)reader.ReadUShort();
            languagesFilter = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 languagesFilter[i] = reader.ReadVarUInt();
            }
            limit = (ushort)reader.ReadVarInt();
            recruitmentTypeFilter = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 recruitmentTypeFilter[i] = reader.ReadSbyte();
            }
            minLevelFilter = reader.ReadShort();
            maxLevelFilter = reader.ReadShort();
            minPlayerLevelFilter = reader.ReadShort();
            maxPlayerLevelFilter = reader.ReadShort();
            minSuccessFilter = reader.ReadVarUInt();
            maxSuccessFilter = reader.ReadVarUInt();
            sortType = reader.ReadSbyte();
        }
        
    }
    
}