

// Generated on 05/18/2023 16:28:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendsGetListMessage : NetworkMessage
    {
        public const uint Id = 8749;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public FriendsGetListMessage()
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