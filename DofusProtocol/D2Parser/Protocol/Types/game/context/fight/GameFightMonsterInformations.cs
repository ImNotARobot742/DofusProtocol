

// Generated on 03/23/2022 09:51:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightMonsterInformations : GameFightAIInformations
    {
        public const short Id = 9097;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint creatureGenericId;
        public sbyte creatureGrade;
        public short creatureLevel;
        
        public GameFightMonsterInformations()
        {
        }
        
        public GameFightMonsterInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions, uint creatureGenericId, sbyte creatureGrade, short creatureLevel)
         : base(contextualId, disposition, look, spawnInfo, wave, stats, previousPositions)
        {
            this.creatureGenericId = creatureGenericId;
            this.creatureGrade = creatureGrade;
            this.creatureLevel = creatureLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)creatureGenericId);
            writer.WriteSbyte(creatureGrade);
            writer.WriteShort(creatureLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            creatureGenericId = reader.ReadVarUShort();
            creatureGrade = reader.ReadSbyte();
            creatureLevel = reader.ReadShort();
        }
        
    }
    
}