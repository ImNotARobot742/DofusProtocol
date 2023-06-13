

// Generated on 06/13/2023 17:00:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightTeamMemberMonsterInformations : FightTeamMemberInformations
    {
        public const short Id = 3808;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public int monsterId;
        public sbyte grade;
        
        public FightTeamMemberMonsterInformations()
        {
        }
        
        public FightTeamMemberMonsterInformations(double id, int monsterId, sbyte grade)
         : base(id)
        {
            this.monsterId = monsterId;
            this.grade = grade;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(monsterId);
            writer.WriteSbyte(grade);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            monsterId = reader.ReadInt();
            grade = reader.ReadSbyte();
        }
        
    }
    
}