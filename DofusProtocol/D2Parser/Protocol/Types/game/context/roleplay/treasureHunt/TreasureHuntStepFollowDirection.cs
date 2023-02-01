

// Generated on 02/01/2023 12:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TreasureHuntStepFollowDirection : TreasureHuntStep
    {
        public const short Id = 437;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte direction;
        public uint mapCount;
        
        public TreasureHuntStepFollowDirection()
        {
        }
        
        public TreasureHuntStepFollowDirection(sbyte direction, uint mapCount)
        {
            this.direction = direction;
            this.mapCount = mapCount;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(direction);
            writer.WriteVarShort((short)mapCount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            direction = reader.ReadSbyte();
            mapCount = reader.ReadVarUShort();
        }
        
    }
    
}