

// Generated on 01/01/2022 14:39:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatSmileyExtraPackListMessage : NetworkMessage
    {
        public const uint Id = 8664;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte[] packIds;
        
        public ChatSmileyExtraPackListMessage()
        {
        }
        
        public ChatSmileyExtraPackListMessage(sbyte[] packIds)
        {
            this.packIds = packIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)(ushort)packIds.Length);
            foreach (var entry in packIds)
            {
                 writer.WriteSbyte(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadVarInt();
            packIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 packIds[i] = reader.ReadSbyte();
            }
        }
        
    }
    
}