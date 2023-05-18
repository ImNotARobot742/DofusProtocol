

// Generated on 05/18/2023 16:28:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class EmoteListMessage : NetworkMessage
    {
        public const uint Id = 5784;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] emoteIds;
        
        public EmoteListMessage()
        {
        }
        
        public EmoteListMessage(uint[] emoteIds)
        {
            this.emoteIds = emoteIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)emoteIds.Length);
            foreach (var entry in emoteIds)
            {
                 writer.WriteUInt(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            emoteIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 emoteIds[i] = reader.ReadUInt();
            }
        }
        
    }
    
}