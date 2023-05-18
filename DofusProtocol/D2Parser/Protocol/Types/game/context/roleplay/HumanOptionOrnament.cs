

// Generated on 05/18/2023 16:29:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class HumanOptionOrnament : HumanOption
    {
        public const short Id = 3411;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint ornamentId;
        public uint level;
        public int leagueId;
        public int ladderPosition;
        
        public HumanOptionOrnament()
        {
        }
        
        public HumanOptionOrnament(uint ornamentId, uint level, int leagueId, int ladderPosition)
        {
            this.ornamentId = ornamentId;
            this.level = level;
            this.leagueId = leagueId;
            this.ladderPosition = ladderPosition;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)ornamentId);
            writer.WriteVarShort((short)level);
            writer.WriteVarShort((short)leagueId);
            writer.WriteInt(ladderPosition);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            ornamentId = reader.ReadVarUShort();
            level = reader.ReadVarUShort();
            leagueId = reader.ReadVarShort();
            ladderPosition = reader.ReadInt();
        }
        
    }
    
}