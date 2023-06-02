

// Generated on 06/02/2023 19:01:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightResultListEntry
    {
        public const short Id = 8846;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint outcome;
        public sbyte wave;
        public Types.FightLoot rewards;
        
        public FightResultListEntry()
        {
        }
        
        public FightResultListEntry(uint outcome, sbyte wave, Types.FightLoot rewards)
        {
            this.outcome = outcome;
            this.wave = wave;
            this.rewards = rewards;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)outcome);
            writer.WriteSbyte(wave);
            rewards.Serialize(writer);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            outcome = reader.ReadVarUShort();
            wave = reader.ReadSbyte();
            rewards = new Types.FightLoot();
            rewards.Deserialize(reader);
        }
        
    }
    
}