

// Generated on 01/01/2022 14:40:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightAIInformations : GameFightFighterInformations
    {
        public const short Id = 858;
        public override short TypeId
        {
            get { return Id; }
        }
        
        
        public GameFightAIInformations()
        {
        }
        
        public GameFightAIInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions)
         : base(contextualId, disposition, look, spawnInfo, wave, stats, previousPositions)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}