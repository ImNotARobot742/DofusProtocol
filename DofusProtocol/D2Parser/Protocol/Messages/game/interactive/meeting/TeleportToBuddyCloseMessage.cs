

// Generated on 02/01/2023 12:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TeleportToBuddyCloseMessage : NetworkMessage
    {
        public const uint Id = 332;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint dungeonId;
        public double buddyId;
        
        public TeleportToBuddyCloseMessage()
        {
        }
        
        public TeleportToBuddyCloseMessage(uint dungeonId, double buddyId)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)dungeonId);
            writer.WriteVarLong(buddyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            dungeonId = reader.ReadVarUShort();
            buddyId = reader.ReadVarULong();
        }
        
    }
    
}