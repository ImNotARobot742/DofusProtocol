

// Generated on 02/01/2023 12:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FriendInformations : AbstractContactInformations
    {
        public const short Id = 9350;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte playerState;
        public uint lastConnection;
        public int achievementPoints;
        public int leagueId;
        public int ladderPosition;
        
        public FriendInformations()
        {
        }
        
        public FriendInformations(int accountId, Types.AccountTagInformation accountTag, sbyte playerState, uint lastConnection, int achievementPoints, int leagueId, int ladderPosition)
         : base(accountId, accountTag)
        {
            this.playerState = playerState;
            this.lastConnection = lastConnection;
            this.achievementPoints = achievementPoints;
            this.leagueId = leagueId;
            this.ladderPosition = ladderPosition;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(playerState);
            writer.WriteVarShort((short)lastConnection);
            writer.WriteInt(achievementPoints);
            writer.WriteVarShort((short)leagueId);
            writer.WriteInt(ladderPosition);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            playerState = reader.ReadSbyte();
            lastConnection = reader.ReadVarUShort();
            achievementPoints = reader.ReadInt();
            leagueId = reader.ReadVarShort();
            ladderPosition = reader.ReadInt();
        }
        
    }
    
}