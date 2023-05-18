

// Generated on 05/18/2023 15:11:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class Idol
    {
        public const short Id = 5798;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint id;
        public uint xpBonusPercent;
        public uint dropBonusPercent;
        
        public Idol()
        {
        }
        
        public Idol(uint id, uint xpBonusPercent, uint dropBonusPercent)
        {
            this.id = id;
            this.xpBonusPercent = xpBonusPercent;
            this.dropBonusPercent = dropBonusPercent;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)id);
            writer.WriteVarShort((short)xpBonusPercent);
            writer.WriteVarShort((short)dropBonusPercent);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUShort();
            xpBonusPercent = reader.ReadVarUShort();
            dropBonusPercent = reader.ReadVarUShort();
        }
        
    }
    
}