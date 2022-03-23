

// Generated on 03/23/2022 09:50:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayArenaLeagueRewardsMessage : NetworkMessage
    {
        public const uint Id = 4959;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint seasonId;
        public uint leagueId;
        public int ladderPosition;
        public bool endSeasonReward;
        
        public GameRolePlayArenaLeagueRewardsMessage()
        {
        }
        
        public GameRolePlayArenaLeagueRewardsMessage(uint seasonId, uint leagueId, int ladderPosition, bool endSeasonReward)
        {
            this.seasonId = seasonId;
            this.leagueId = leagueId;
            this.ladderPosition = ladderPosition;
            this.endSeasonReward = endSeasonReward;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)seasonId);
            writer.WriteVarShort((short)leagueId);
            writer.WriteInt(ladderPosition);
            writer.WriteBoolean(endSeasonReward);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            seasonId = reader.ReadVarUShort();
            leagueId = reader.ReadVarUShort();
            ladderPosition = reader.ReadInt();
            endSeasonReward = reader.ReadBoolean();
        }
        
    }
    
}