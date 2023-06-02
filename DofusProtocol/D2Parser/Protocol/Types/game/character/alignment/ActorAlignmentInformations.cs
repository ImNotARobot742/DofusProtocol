

// Generated on 06/02/2023 19:01:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ActorAlignmentInformations
    {
        public const short Id = 7796;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public sbyte alignmentSide;
        public sbyte alignmentValue;
        public sbyte alignmentGrade;
        public double characterPower;
        
        public ActorAlignmentInformations()
        {
        }
        
        public ActorAlignmentInformations(sbyte alignmentSide, sbyte alignmentValue, sbyte alignmentGrade, double characterPower)
        {
            this.alignmentSide = alignmentSide;
            this.alignmentValue = alignmentValue;
            this.alignmentGrade = alignmentGrade;
            this.characterPower = characterPower;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(alignmentSide);
            writer.WriteSbyte(alignmentValue);
            writer.WriteSbyte(alignmentGrade);
            writer.WriteDouble(characterPower);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            alignmentSide = reader.ReadSbyte();
            alignmentValue = reader.ReadSbyte();
            alignmentGrade = reader.ReadSbyte();
            characterPower = reader.ReadDouble();
        }
        
    }
    
}