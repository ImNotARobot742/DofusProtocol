

// Generated on 03/23/2022 09:50:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TaxCollectorAttackedMessage : NetworkMessage
    {
        public const uint Id = 8771;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint firstNameId;
        public uint lastNameId;
        public short worldX;
        public short worldY;
        public double mapId;
        public uint subAreaId;
        public Types.BasicGuildInformations guild;
        
        public TaxCollectorAttackedMessage()
        {
        }
        
        public TaxCollectorAttackedMessage(uint firstNameId, uint lastNameId, short worldX, short worldY, double mapId, uint subAreaId, Types.BasicGuildInformations guild)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.guild = guild;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)firstNameId);
            writer.WriteVarShort((short)lastNameId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((short)subAreaId);
            guild.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            firstNameId = reader.ReadVarUShort();
            lastNameId = reader.ReadVarUShort();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUShort();
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
        }
        
    }
    
}