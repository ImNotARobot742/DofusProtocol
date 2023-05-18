

// Generated on 05/18/2023 16:29:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ActorExtendedAlignmentInformations : ActorAlignmentInformations
    {
        public const short Id = 5439;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint honor;
        public uint honorGradeFloor;
        public uint honorNextGradeFloor;
        public sbyte aggressable;
        
        public ActorExtendedAlignmentInformations()
        {
        }
        
        public ActorExtendedAlignmentInformations(sbyte alignmentSide, sbyte alignmentValue, sbyte alignmentGrade, double characterPower, uint honor, uint honorGradeFloor, uint honorNextGradeFloor, sbyte aggressable)
         : base(alignmentSide, alignmentValue, alignmentGrade, characterPower)
        {
            this.honor = honor;
            this.honorGradeFloor = honorGradeFloor;
            this.honorNextGradeFloor = honorNextGradeFloor;
            this.aggressable = aggressable;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)honor);
            writer.WriteVarShort((short)honorGradeFloor);
            writer.WriteVarShort((short)honorNextGradeFloor);
            writer.WriteSbyte(aggressable);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            honor = reader.ReadVarUShort();
            honorGradeFloor = reader.ReadVarUShort();
            honorNextGradeFloor = reader.ReadVarUShort();
            aggressable = reader.ReadSbyte();
        }
        
    }
    
}