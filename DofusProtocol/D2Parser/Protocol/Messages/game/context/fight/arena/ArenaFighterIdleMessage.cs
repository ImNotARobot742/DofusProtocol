

// Generated on 05/18/2023 15:10:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ArenaFighterIdleMessage : NetworkMessage
    {
        public const uint Id = 2584;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ArenaFighterIdleMessage()
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