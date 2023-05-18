

// Generated on 05/18/2023 16:28:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayArenaUnregisterMessage : NetworkMessage
    {
        public const uint Id = 5301;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public GameRolePlayArenaUnregisterMessage()
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