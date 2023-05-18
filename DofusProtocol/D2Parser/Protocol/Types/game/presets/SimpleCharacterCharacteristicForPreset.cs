

// Generated on 05/18/2023 15:11:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SimpleCharacterCharacteristicForPreset
    {
        public const short Id = 1231;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public string keyword;
        public int @base;
        public int additionnal;
        
        public SimpleCharacterCharacteristicForPreset()
        {
        }
        
        public SimpleCharacterCharacteristicForPreset(string keyword, int @base, int additionnal)
        {
            this.keyword = keyword;
            this.@base = @base;
            this.additionnal = additionnal;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(keyword);
            writer.WriteVarInt((int)@base);
            writer.WriteVarInt((int)additionnal);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            keyword = reader.ReadUTF();
            @base = reader.ReadVarInt();
            additionnal = reader.ReadVarInt();
        }
        
    }
    
}