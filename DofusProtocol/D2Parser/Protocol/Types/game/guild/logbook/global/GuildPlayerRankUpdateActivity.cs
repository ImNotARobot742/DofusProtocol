

// Generated on 03/23/2022 09:51:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildPlayerRankUpdateActivity : GuildLogbookEntryBasicInformation
    {
        public const short Id = 9478;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.GuildRankMinimalInformation guildRankMinimalInfos;
        public double playerId;
        public string playerName;
        
        public GuildPlayerRankUpdateActivity()
        {
        }
        
        public GuildPlayerRankUpdateActivity(uint id, double date, Types.GuildRankMinimalInformation guildRankMinimalInfos, double playerId, string playerName)
         : base(id, date)
        {
            this.guildRankMinimalInfos = guildRankMinimalInfos;
            this.playerId = playerId;
            this.playerName = playerName;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            guildRankMinimalInfos.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            guildRankMinimalInfos = new Types.GuildRankMinimalInformation();
            guildRankMinimalInfos.Deserialize(reader);
            playerId = reader.ReadVarULong();
            playerName = reader.ReadUTF();
        }
        
    }
    
}