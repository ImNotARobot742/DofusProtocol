

// Generated on 01/01/2022 14:40:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ShortcutSmiley : Shortcut
    {
        public const short Id = 4590;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint smileyId;
        
        public ShortcutSmiley()
        {
        }
        
        public ShortcutSmiley(sbyte slot, uint smileyId)
         : base(slot)
        {
            this.smileyId = smileyId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)smileyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            smileyId = reader.ReadVarUShort();
        }
        
    }
    
}