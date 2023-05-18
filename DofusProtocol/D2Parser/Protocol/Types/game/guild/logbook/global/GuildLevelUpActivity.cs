

// Generated on 05/18/2023 15:11:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildLevelUpActivity : GuildLogbookEntryBasicInformation
    {
        public const short Id = 5284;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public byte newGuildLevel;
        
        public GuildLevelUpActivity()
        {
        }
        
        public GuildLevelUpActivity(uint id, double date, byte newGuildLevel)
         : base(id, date)
        {
            this.newGuildLevel = newGuildLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(newGuildLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            newGuildLevel = reader.ReadByte();
        }
        
    }
    
}