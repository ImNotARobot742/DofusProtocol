

// Generated on 05/18/2023 16:29:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TeleportBuddiesMessage : NetworkMessage
    {
        public const uint Id = 2679;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint dungeonId;
        
        public TeleportBuddiesMessage()
        {
        }
        
        public TeleportBuddiesMessage(uint dungeonId)
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