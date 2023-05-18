

// Generated on 05/18/2023 16:29:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterToRemodelInformations : CharacterRemodelingInformation
    {
        public const short Id = 2748;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte possibleChangeMask;
        public sbyte mandatoryChangeMask;
        
        public CharacterToRemodelInformations()
        {
        }
        
        public CharacterToRemodelInformations(double id, string name, sbyte breed, bool sex, uint cosmeticId, int[] colors, sbyte possibleChangeMask, sbyte mandatoryChangeMask)
         : base(id, name, breed, sex, cosmeticId, colors)
        {
            this.possibleChangeMask = possibleChangeMask;
            this.mandatoryChangeMask = mandatoryChangeMask;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(possibleChangeMask);
            writer.WriteSbyte(mandatoryChangeMask);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            possibleChangeMask = reader.ReadSbyte();
            mandatoryChangeMask = reader.ReadSbyte();
        }
        
    }
    
}