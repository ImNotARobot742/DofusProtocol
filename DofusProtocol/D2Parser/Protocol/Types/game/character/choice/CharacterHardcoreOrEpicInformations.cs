

// Generated on 03/23/2022 09:51:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterHardcoreOrEpicInformations : CharacterBaseInformations
    {
        public const short Id = 8481;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte deathState;
        public uint deathCount;
        public uint deathMaxLevel;
        
        public CharacterHardcoreOrEpicInformations()
        {
        }
        
        public CharacterHardcoreOrEpicInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, bool sex, sbyte deathState, uint deathCount, uint deathMaxLevel)
         : base(id, name, level, entityLook, breed, sex)
        {
            this.deathState = deathState;
            this.deathCount = deathCount;
            this.deathMaxLevel = deathMaxLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(deathState);
            writer.WriteVarShort((short)deathCount);
            writer.WriteVarShort((short)deathMaxLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            deathState = reader.ReadSbyte();
            deathCount = reader.ReadVarUShort();
            deathMaxLevel = reader.ReadVarUShort();
        }
        
    }
    
}