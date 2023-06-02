

// Generated on 06/02/2023 19:00:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendDeleteRequestMessage : NetworkMessage
    {
        public const uint Id = 9850;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int accountId;
        
        public FriendDeleteRequestMessage()
        {
        }
        
        public FriendDeleteRequestMessage(int accountId)
        {
            this.accountId = accountId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(accountId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            accountId = reader.ReadInt();
        }
        
    }
    
}