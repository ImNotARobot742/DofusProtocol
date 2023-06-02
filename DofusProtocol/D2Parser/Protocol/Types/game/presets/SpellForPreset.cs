

// Generated on 06/02/2023 19:01:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SpellForPreset
    {
        public const short Id = 8020;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint spellId;
        public short[] shortcuts;
        
        public SpellForPreset()
        {
        }
        
        public SpellForPreset(uint spellId, short[] shortcuts)
        {
            this.spellId = spellId;
            this.shortcuts = shortcuts;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)spellId);
            writer.WriteShort((short)shortcuts.Length);
            foreach (var entry in shortcuts)
            {
                 writer.WriteShort(entry);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            spellId = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            shortcuts = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 shortcuts[i] = reader.ReadShort();
            }
        }
        
    }
    
}