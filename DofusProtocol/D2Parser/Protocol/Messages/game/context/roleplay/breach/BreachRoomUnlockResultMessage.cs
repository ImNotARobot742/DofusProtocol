

// Generated on 01/01/2022 14:39:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachRoomUnlockResultMessage : NetworkMessage
    {
        public const uint Id = 3212;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte roomId;
        public sbyte result;
        
        public BreachRoomUnlockResultMessage()
        {
        }
        
        public BreachRoomUnlockResultMessage(sbyte roomId, sbyte result)
        {
            this.roomId = roomId;
            this.result = result;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(roomId);
            writer.WriteSbyte(result);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            roomId = reader.ReadSbyte();
            result = reader.ReadSbyte();
        }
        
    }
    
}