

// Generated on 03/23/2022 09:50:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class RemoveListenerOnSynchronizedStorageMessage : NetworkMessage
    {
        public const uint Id = 107;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string player;
        
        public RemoveListenerOnSynchronizedStorageMessage()
        {
        }
        
        public RemoveListenerOnSynchronizedStorageMessage(string player)
        {
            this.player = player;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(player);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            player = reader.ReadUTF();
        }
        
    }
    
}