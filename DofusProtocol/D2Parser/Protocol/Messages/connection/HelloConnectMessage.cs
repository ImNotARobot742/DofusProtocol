

// Generated on 01/01/2022 14:39:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HelloConnectMessage : NetworkMessage
    {
        public const uint Id = 6739;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string salt;
        public sbyte[] key;
        
        public HelloConnectMessage()
        {
        }
        
        public HelloConnectMessage(string salt, sbyte[] key)
        {
            this.salt = salt;
            this.key = key;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(salt);
            writer.WriteVarInt((int)(ushort)key.Length);
            foreach (var entry in key)
            {
                 writer.WriteSbyte(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            salt = reader.ReadUTF();
            var limit = (ushort)reader.ReadVarInt();
            key = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 key[i] = reader.ReadSbyte();
            }
        }
        
    }
    
}