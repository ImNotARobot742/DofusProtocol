

// Generated on 03/23/2022 09:51:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class IdolsPreset : Preset
    {
        public const short Id = 2034;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public short iconId;
        public uint[] idolIds;
        
        public IdolsPreset()
        {
        }
        
        public IdolsPreset(short id, short iconId, uint[] idolIds)
         : base(id)
        {
            this.iconId = iconId;
            this.idolIds = idolIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(iconId);
            writer.WriteShort((short)idolIds.Length);
            foreach (var entry in idolIds)
            {
                 writer.WriteVarShort((short)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            iconId = reader.ReadShort();
            var limit = (ushort)reader.ReadUShort();
            idolIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 idolIds[i] = reader.ReadVarUShort();
            }
        }
        
    }
    
}