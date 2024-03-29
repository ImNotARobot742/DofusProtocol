

// Generated on 06/13/2023 17:00:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightSpellCooldown
    {
        public const short Id = 9834;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int spellId;
        public sbyte cooldown;
        
        public GameFightSpellCooldown()
        {
        }
        
        public GameFightSpellCooldown(int spellId, sbyte cooldown)
        {
            this.spellId = spellId;
            this.cooldown = cooldown;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(spellId);
            writer.WriteSbyte(cooldown);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            spellId = reader.ReadInt();
            cooldown = reader.ReadSbyte();
        }
        
    }
    
}