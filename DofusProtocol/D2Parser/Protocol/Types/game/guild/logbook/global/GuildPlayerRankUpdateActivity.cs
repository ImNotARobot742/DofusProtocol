

// Generated on 06/13/2023 17:00:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildPlayerRankUpdateActivity : GuildLogbookEntryBasicInformation
    {
        public const short Id = 222;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.GuildRankMinimalInformation guildRankMinimalInfos;
        public double sourcePlayerId;
        public double targetPlayerId;
        public string sourcePlayerName;
        public string targetPlayerName;
        
        public GuildPlayerRankUpdateActivity()
        {
        }
        
        public GuildPlayerRankUpdateActivity(uint id, double date, Types.GuildRankMinimalInformation guildRankMinimalInfos, double sourcePlayerId, double targetPlayerId, string sourcePlayerName, string targetPlayerName)
         : base(id, date)
        {
            this.guildRankMinimalInfos = guildRankMinimalInfos;
            this.sourcePlayerId = sourcePlayerId;
            this.targetPlayerId = targetPlayerId;
            this.sourcePlayerName = sourcePlayerName;
            this.targetPlayerName = targetPlayerName;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            guildRankMinimalInfos.Serialize(writer);
            writer.WriteVarLong(sourcePlayerId);
            writer.WriteVarLong(targetPlayerId);
            writer.WriteUTF(sourcePlayerName);
            writer.WriteUTF(targetPlayerName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            guildRankMinimalInfos = new Types.GuildRankMinimalInformation();
            guildRankMinimalInfos.Deserialize(reader);
            sourcePlayerId = reader.ReadVarULong();
            targetPlayerId = reader.ReadVarULong();
            sourcePlayerName = reader.ReadUTF();
            targetPlayerName = reader.ReadUTF();
        }
        
    }
    
}