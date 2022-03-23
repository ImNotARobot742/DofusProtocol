

// Generated on 03/23/2022 09:51:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ShortcutEmote : Shortcut
    {
        public const short Id = 3071;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public ushort emoteId;
        
        public ShortcutEmote()
        {
        }
        
        public ShortcutEmote(sbyte slot, ushort emoteId)
         : base(slot)
        {
            this.emoteId = emoteId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUShort(emoteId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            emoteId = reader.ReadUShort();
        }
        
    }
    
}