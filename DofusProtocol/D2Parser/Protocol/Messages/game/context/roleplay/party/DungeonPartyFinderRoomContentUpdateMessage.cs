

// Generated on 06/13/2023 16:59:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DungeonPartyFinderRoomContentUpdateMessage : NetworkMessage
    {
        public const uint Id = 9972;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint dungeonId;
        public Types.DungeonPartyFinderPlayer[] addedPlayers;
        public double[] removedPlayersIds;
        
        public DungeonPartyFinderRoomContentUpdateMessage()
        {
        }
        
        public DungeonPartyFinderRoomContentUpdateMessage(uint dungeonId, Types.DungeonPartyFinderPlayer[] addedPlayers, double[] removedPlayersIds)
        {
            this.dungeonId = dungeonId;
            this.addedPlayers = addedPlayers;
            this.removedPlayersIds = removedPlayersIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)dungeonId);
            writer.WriteShort((short)addedPlayers.Length);
            foreach (var entry in addedPlayers)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)removedPlayersIds.Length);
            foreach (var entry in removedPlayersIds)
            {
                 writer.WriteVarLong(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            dungeonId = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            addedPlayers = new Types.DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 addedPlayers[i] = new Types.DungeonPartyFinderPlayer();
                 addedPlayers[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            removedPlayersIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 removedPlayersIds[i] = reader.ReadVarULong();
            }
        }
        
    }
    
}