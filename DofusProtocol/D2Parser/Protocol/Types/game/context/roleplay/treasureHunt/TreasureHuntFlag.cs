

// Generated on 01/01/2022 14:40:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TreasureHuntFlag
    {
        public const short Id = 4191;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double mapId;
        public sbyte state;
        
        public TreasureHuntFlag()
        {
        }
        
        public TreasureHuntFlag(double mapId, sbyte state)
        {
            this.mapId = mapId;
            this.state = state;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(mapId);
            writer.WriteSbyte(state);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            mapId = reader.ReadDouble();
            state = reader.ReadSbyte();
        }
        
    }
    
}