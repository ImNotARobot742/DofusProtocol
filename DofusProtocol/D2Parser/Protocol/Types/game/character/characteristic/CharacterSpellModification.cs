

// Generated on 06/13/2023 17:00:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterSpellModification
    {
        public const short Id = 4883;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public sbyte modificationType;
        public uint spellId;
        public Types.CharacterCharacteristicDetailed value;
        
        public CharacterSpellModification()
        {
        }
        
        public CharacterSpellModification(sbyte modificationType, uint spellId, Types.CharacterCharacteristicDetailed value)
        {
            this.modificationType = modificationType;
            this.spellId = spellId;
            this.value = value;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(modificationType);
            writer.WriteVarShort((short)spellId);
            value.Serialize(writer);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            modificationType = reader.ReadSbyte();
            spellId = reader.ReadVarUShort();
            value = new Types.CharacterCharacteristicDetailed();
            value.Deserialize(reader);
        }
        
    }
    
}