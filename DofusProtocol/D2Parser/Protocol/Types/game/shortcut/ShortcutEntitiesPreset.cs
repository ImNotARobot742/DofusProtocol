

// Generated on 05/18/2023 16:29:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ShortcutEntitiesPreset : Shortcut
    {
        public const short Id = 4371;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public short presetId;
        
        public ShortcutEntitiesPreset()
        {
        }
        
        public ShortcutEntitiesPreset(sbyte slot, short presetId)
         : base(slot)
        {
            this.presetId = presetId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(presetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            presetId = reader.ReadShort();
        }
        
    }
    
}