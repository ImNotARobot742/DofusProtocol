

// Generated on 02/01/2023 12:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class MapCoordinatesAndId : MapCoordinates
    {
        public const short Id = 1303;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double mapId;
        
        public MapCoordinatesAndId()
        {
        }
        
        public MapCoordinatesAndId(short worldX, short worldY, double mapId)
         : base(worldX, worldY)
        {
            this.mapId = mapId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(mapId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            mapId = reader.ReadDouble();
        }
        
    }
    
}