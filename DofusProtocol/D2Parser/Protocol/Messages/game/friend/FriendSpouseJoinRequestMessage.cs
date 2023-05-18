

// Generated on 05/18/2023 15:10:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendSpouseJoinRequestMessage : NetworkMessage
    {
        public const uint Id = 1410;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public FriendSpouseJoinRequestMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}