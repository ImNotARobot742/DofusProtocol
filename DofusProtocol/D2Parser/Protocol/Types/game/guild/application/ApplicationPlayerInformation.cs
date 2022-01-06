

// Generated on 01/01/2022 14:40:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ApplicationPlayerInformation
    {
        public const short Id = 3872;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint playerId;
        public string playerName;
        public sbyte breed;
        public bool sex;
        public uint level;
        public uint accountId;
        public string accountTag;
        public string accountNickname;
        public Types.PlayerStatus status;
        
        public ApplicationPlayerInformation()
        {
        }
        
        public ApplicationPlayerInformation(uint playerId, string playerName, sbyte breed, bool sex, uint level, uint accountId, string accountTag, string accountNickname, Types.PlayerStatus status)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.breed = breed;
            this.sex = sex;
            this.level = level;
            this.accountId = accountId;
            this.accountTag = accountTag;
            this.accountNickname = accountNickname;
            this.status = status;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)playerId);
            writer.WriteUTF(playerName);
            writer.WriteSbyte(breed);
            writer.WriteBoolean(sex);
            writer.WriteVarInt((int)level);
            writer.WriteVarInt((int)accountId);
            writer.WriteUTF(accountTag);
            writer.WriteUTF(accountNickname);
            status.Serialize(writer);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            playerId = reader.ReadVarUInt();
            playerName = reader.ReadUTF();
            breed = reader.ReadSbyte();
            sex = reader.ReadBoolean();
            level = reader.ReadVarUInt();
            accountId = reader.ReadVarUInt();
            accountTag = reader.ReadUTF();
            accountNickname = reader.ReadUTF();
            status = new Types.PlayerStatus();
            status.Deserialize(reader);
        }
        
    }
    
}