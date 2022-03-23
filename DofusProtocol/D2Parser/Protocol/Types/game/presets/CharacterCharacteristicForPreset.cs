

// Generated on 03/23/2022 09:51:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterCharacteristicForPreset : SimpleCharacterCharacteristicForPreset
    {
        public const short Id = 1673;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public int stuff;
        
        public CharacterCharacteristicForPreset()
        {
        }
        
        public CharacterCharacteristicForPreset(string keyword, int @base, int additionnal, int stuff)
         : base(keyword, @base, additionnal)
        {
            this.stuff = stuff;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)stuff);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            stuff = reader.ReadVarShort();
        }
        
    }
    
}