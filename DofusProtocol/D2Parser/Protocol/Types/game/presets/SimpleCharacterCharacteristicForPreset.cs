

// Generated on 03/23/2022 09:51:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SimpleCharacterCharacteristicForPreset
    {
        public const short Id = 7594;
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
            writer.WriteVarShort((short)@base);
            writer.WriteVarShort((short)additionnal);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            keyword = reader.ReadUTF();
            @base = reader.ReadVarShort();
            additionnal = reader.ReadVarShort();
        }
        
    }
    
}