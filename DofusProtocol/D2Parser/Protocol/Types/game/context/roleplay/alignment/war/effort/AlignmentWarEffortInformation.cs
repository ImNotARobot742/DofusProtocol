

// Generated on 06/13/2023 17:00:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AlignmentWarEffortInformation
    {
        public const short Id = 8928;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public sbyte alignmentSide;
        public double alignmentWarEffort;
        
        public AlignmentWarEffortInformation()
        {
        }
        
        public AlignmentWarEffortInformation(sbyte alignmentSide, double alignmentWarEffort)
        {
            this.alignmentSide = alignmentSide;
            this.alignmentWarEffort = alignmentWarEffort;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(alignmentSide);
            writer.WriteVarLong(alignmentWarEffort);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            alignmentSide = reader.ReadSbyte();
            alignmentWarEffort = reader.ReadVarULong();
        }
        
    }
    
}