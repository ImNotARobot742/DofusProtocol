

// Generated on 06/02/2023 19:00:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DungeonPartyFinderListenErrorMessage : NetworkMessage
    {
        public const uint Id = 5578;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint dungeonId;
        
        public DungeonPartyFinderListenErrorMessage()
        {
        }
        
        public DungeonPartyFinderListenErrorMessage(uint dungeonId)
        {
            this.dungeonId = dungeonId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)dungeonId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            dungeonId = reader.ReadVarUShort();
        }
        
    }
    
}