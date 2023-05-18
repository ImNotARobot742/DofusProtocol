

// Generated on 05/18/2023 15:11:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterCharacteristicForPreset : SimpleCharacterCharacteristicForPreset
    {
        public const short Id = 8801;
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
            writer.WriteVarInt((int)stuff);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            stuff = reader.ReadVarInt();
        }
        
    }
    
}