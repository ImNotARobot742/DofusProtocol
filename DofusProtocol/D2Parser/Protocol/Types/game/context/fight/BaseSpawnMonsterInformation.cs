

// Generated on 03/23/2022 09:51:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class BaseSpawnMonsterInformation : SpawnInformation
    {
        public const short Id = 5339;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint creatureGenericId;
        
        public BaseSpawnMonsterInformation()
        {
        }
        
        public BaseSpawnMonsterInformation(uint creatureGenericId)
        {
            this.creatureGenericId = creatureGenericId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)creatureGenericId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            creatureGenericId = reader.ReadVarUShort();
        }
        
    }
    
}