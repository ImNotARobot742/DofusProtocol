

// Generated on 01/01/2022 14:39:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class NotificationListMessage : NetworkMessage
    {
        public const uint Id = 7026;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int[] flags;
        
        public NotificationListMessage()
        {
        }
        
        public NotificationListMessage(int[] flags)
        {
            this.flags = flags;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)flags.Length);
            foreach (var entry in flags)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            flags = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 flags[i] = reader.ReadVarInt();
            }
        }
        
    }
    
}