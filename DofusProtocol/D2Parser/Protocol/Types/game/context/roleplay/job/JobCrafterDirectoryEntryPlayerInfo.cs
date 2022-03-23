

// Generated on 03/23/2022 09:51:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class JobCrafterDirectoryEntryPlayerInfo
    {
        public const short Id = 6128;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double playerId;
        public string playerName;
        public sbyte alignmentSide;
        public sbyte breed;
        public bool sex;
        public bool isInWorkshop;
        public short worldX;
        public short worldY;
        public double mapId;
        public uint subAreaId;
        public bool canCraftLegendary;
        public Types.PlayerStatus status;
        
        public JobCrafterDirectoryEntryPlayerInfo()
        {
        }
        
        public JobCrafterDirectoryEntryPlayerInfo(double playerId, string playerName, sbyte alignmentSide, sbyte breed, bool sex, bool isInWorkshop, short worldX, short worldY, double mapId, uint subAreaId, bool canCraftLegendary, Types.PlayerStatus status)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.alignmentSide = alignmentSide;
            this.breed = breed;
            this.sex = sex;
            this.isInWorkshop = isInWorkshop;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.canCraftLegendary = canCraftLegendary;
            this.status = status;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSbyte(alignmentSide);
            writer.WriteSbyte(breed);
            writer.WriteBoolean(sex);
            writer.WriteBoolean(isInWorkshop);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((short)subAreaId);
            writer.WriteBoolean(canCraftLegendary);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            playerId = reader.ReadVarULong();
            playerName = reader.ReadUTF();
            alignmentSide = reader.ReadSbyte();
            breed = reader.ReadSbyte();
            sex = reader.ReadBoolean();
            isInWorkshop = reader.ReadBoolean();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUShort();
            canCraftLegendary = reader.ReadBoolean();
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
        }
        
    }
    
}