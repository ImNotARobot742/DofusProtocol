

// Generated on 06/13/2023 17:00:05
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class DungeonPartyFinderPlayer
    {
        public const short Id = 7952;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double playerId;
        public string playerName;
        public sbyte breed;
        public bool sex;
        public uint level;
        
        public DungeonPartyFinderPlayer()
        {
        }
        
        public DungeonPartyFinderPlayer(double playerId, string playerName, sbyte breed, bool sex, uint level)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.breed = breed;
            this.sex = sex;
            this.level = level;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSbyte(breed);
            writer.WriteBoolean(sex);
            writer.WriteVarShort((short)level);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            playerId = reader.ReadVarULong();
            playerName = reader.ReadUTF();
            breed = reader.ReadSbyte();
            sex = reader.ReadBoolean();
            level = reader.ReadVarUShort();
        }
        
    }
    
}