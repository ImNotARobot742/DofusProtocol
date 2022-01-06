

// Generated on 01/01/2022 14:40:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameRolePlayMutantInformations : GameRolePlayHumanoidInformations
    {
        public const short Id = 4120;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint monsterId;
        public sbyte powerLevel;
        
        public GameRolePlayMutantInformations()
        {
        }
        
        public GameRolePlayMutantInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, string name, Types.HumanInformations humanoidInfo, int accountId, uint monsterId, sbyte powerLevel)
         : base(contextualId, disposition, look, name, humanoidInfo, accountId)
        {
            this.monsterId = monsterId;
            this.powerLevel = powerLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)monsterId);
            writer.WriteSbyte(powerLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            monsterId = reader.ReadVarUShort();
            powerLevel = reader.ReadSbyte();
        }
        
    }
    
}