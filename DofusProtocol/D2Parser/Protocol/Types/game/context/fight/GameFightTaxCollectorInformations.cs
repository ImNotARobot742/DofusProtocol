

// Generated on 05/18/2023 16:29:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightTaxCollectorInformations : GameFightAIInformations
    {
        public const short Id = 6212;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint firstNameId;
        public uint lastNameId;
        public byte level;
        
        public GameFightTaxCollectorInformations()
        {
        }
        
        public GameFightTaxCollectorInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions, uint firstNameId, uint lastNameId, byte level)
         : base(contextualId, disposition, look, spawnInfo, wave, stats, previousPositions)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.level = level;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)firstNameId);
            writer.WriteVarShort((short)lastNameId);
            writer.WriteByte(level);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            firstNameId = reader.ReadVarUShort();
            lastNameId = reader.ReadVarUShort();
            level = reader.ReadByte();
        }
        
    }
    
}