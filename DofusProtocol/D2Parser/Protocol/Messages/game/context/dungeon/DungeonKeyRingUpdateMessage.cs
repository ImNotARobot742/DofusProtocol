

// Generated on 06/13/2023 16:59:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DungeonKeyRingUpdateMessage : NetworkMessage
    {
        public const uint Id = 2060;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint dungeonId;
        public bool available;
        
        public DungeonKeyRingUpdateMessage()
        {
        }
        
        public DungeonKeyRingUpdateMessage(uint dungeonId, bool available)
        {
            this.dungeonId = dungeonId;
            this.available = available;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)dungeonId);
            writer.WriteBoolean(available);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            dungeonId = reader.ReadVarUShort();
            available = reader.ReadBoolean();
        }
        
    }
    
}