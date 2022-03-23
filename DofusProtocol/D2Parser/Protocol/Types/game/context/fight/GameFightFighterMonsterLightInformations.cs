

// Generated on 03/23/2022 09:51:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightFighterMonsterLightInformations : GameFightFighterLightInformations
    {
        public const short Id = 87;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint creatureGenericId;
        
        public GameFightFighterMonsterLightInformations()
        {
        }
        
        public GameFightFighterMonsterLightInformations(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed, uint creatureGenericId)
         : base(sex, alive, id, wave, level, breed)
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