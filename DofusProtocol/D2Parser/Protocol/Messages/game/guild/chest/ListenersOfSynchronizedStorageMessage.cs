

// Generated on 02/01/2023 12:53:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ListenersOfSynchronizedStorageMessage : NetworkMessage
    {
        public const uint Id = 8019;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string[] players;
        
        public ListenersOfSynchronizedStorageMessage()
        {
        }
        
        public ListenersOfSynchronizedStorageMessage(string[] players)
        {
            this.players = players;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)players.Length);
            foreach (var entry in players)
            {
                 writer.WriteUTF(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            players = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 players[i] = reader.ReadUTF();
            }
        }
        
    }
    
}