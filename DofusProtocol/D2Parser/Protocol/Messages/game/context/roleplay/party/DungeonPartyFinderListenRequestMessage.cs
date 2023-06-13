

// Generated on 06/13/2023 16:59:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DungeonPartyFinderListenRequestMessage : NetworkMessage
    {
        public const uint Id = 613;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint dungeonId;
        
        public DungeonPartyFinderListenRequestMessage()
        {
        }
        
        public DungeonPartyFinderListenRequestMessage(uint dungeonId)
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