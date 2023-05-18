

// Generated on 05/18/2023 16:29:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class LeagueFriendInformations : AbstractContactInformations
    {
        public const short Id = 6769;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double playerId;
        public string playerName;
        public sbyte breed;
        public bool sex;
        public uint level;
        public int leagueId;
        public int totalLeaguePoints;
        public int ladderPosition;
        
        public LeagueFriendInformations()
        {
        }
        
        public LeagueFriendInformations(int accountId, Types.AccountTagInformation accountTag, double playerId, string playerName, sbyte breed, bool sex, uint level, int leagueId, int totalLeaguePoints, int ladderPosition)
         : base(accountId, accountTag)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.breed = breed;
            this.sex = sex;
            this.level = level;
            this.leagueId = leagueId;
            this.totalLeaguePoints = totalLeaguePoints;
            this.ladderPosition = ladderPosition;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSbyte(breed);
            writer.WriteBoolean(sex);
            writer.WriteVarShort((short)level);
            writer.WriteVarShort((short)leagueId);
            writer.WriteVarShort((short)totalLeaguePoints);
            writer.WriteInt(ladderPosition);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarULong();
            playerName = reader.ReadUTF();
            breed = reader.ReadSbyte();
            sex = reader.ReadBoolean();
            level = reader.ReadVarUShort();
            leagueId = reader.ReadVarShort();
            totalLeaguePoints = reader.ReadVarShort();
            ladderPosition = reader.ReadInt();
        }
        
    }
    
}