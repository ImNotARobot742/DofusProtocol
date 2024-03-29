

// Generated on 06/13/2023 17:00:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class HumanOptionTitle : HumanOption
    {
        public const short Id = 9965;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint titleId;
        public string titleParam;
        
        public HumanOptionTitle()
        {
        }
        
        public HumanOptionTitle(uint titleId, string titleParam)
        {
            this.titleId = titleId;
            this.titleParam = titleParam;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)titleId);
            writer.WriteUTF(titleParam);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            titleId = reader.ReadVarUShort();
            titleParam = reader.ReadUTF();
        }
        
    }
    
}