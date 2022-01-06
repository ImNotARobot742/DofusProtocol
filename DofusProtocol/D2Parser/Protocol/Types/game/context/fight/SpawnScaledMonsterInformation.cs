

// Generated on 01/01/2022 14:40:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SpawnScaledMonsterInformation : BaseSpawnMonsterInformation
    {
        public const short Id = 6368;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public short creatureLevel;
        
        public SpawnScaledMonsterInformation()
        {
        }
        
        public SpawnScaledMonsterInformation(uint creatureGenericId, short creatureLevel)
         : base(creatureGenericId)
        {
            this.creatureLevel = creatureLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(creatureLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            creatureLevel = reader.ReadShort();
        }
        
    }
    
}