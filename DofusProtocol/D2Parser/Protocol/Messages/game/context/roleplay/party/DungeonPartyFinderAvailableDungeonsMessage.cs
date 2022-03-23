

// Generated on 03/23/2022 09:50:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DungeonPartyFinderAvailableDungeonsMessage : NetworkMessage
    {
        public const uint Id = 1688;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] dungeonIds;
        
        public DungeonPartyFinderAvailableDungeonsMessage()
        {
        }
        
        public DungeonPartyFinderAvailableDungeonsMessage(uint[] dungeonIds)
        {
            this.dungeonIds = dungeonIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)dungeonIds.Length);
            foreach (var entry in dungeonIds)
            {
                 writer.WriteVarShort((short)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            dungeonIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 dungeonIds[i] = reader.ReadVarUShort();
            }
        }
        
    }
    
}