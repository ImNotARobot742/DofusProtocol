

// Generated on 03/23/2022 09:50:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DungeonPartyFinderRoomContentMessage : NetworkMessage
    {
        public const uint Id = 726;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint dungeonId;
        public Types.DungeonPartyFinderPlayer[] players;
        
        public DungeonPartyFinderRoomContentMessage()
        {
        }
        
        public DungeonPartyFinderRoomContentMessage(uint dungeonId, Types.DungeonPartyFinderPlayer[] players)
        {
            this.dungeonId = dungeonId;
            this.players = players;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)dungeonId);
            writer.WriteShort((short)players.Length);
            foreach (var entry in players)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            dungeonId = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            players = new Types.DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 players[i] = new Types.DungeonPartyFinderPlayer();
                 players[i].Deserialize(reader);
            }
        }
        
    }
    
}