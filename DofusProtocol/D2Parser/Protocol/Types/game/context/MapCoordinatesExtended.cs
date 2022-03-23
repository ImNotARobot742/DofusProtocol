

// Generated on 03/23/2022 09:51:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class MapCoordinatesExtended : MapCoordinatesAndId
    {
        public const short Id = 7377;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        
        public MapCoordinatesExtended()
        {
        }
        
        public MapCoordinatesExtended(short worldX, short worldY, double mapId, uint subAreaId)
         : base(worldX, worldY, mapId)
        {
            this.subAreaId = subAreaId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)subAreaId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            subAreaId = reader.ReadVarUShort();
        }
        
    }
    
}