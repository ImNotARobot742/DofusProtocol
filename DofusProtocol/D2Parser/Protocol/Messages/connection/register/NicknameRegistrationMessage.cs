

// Generated on 01/01/2022 14:39:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class NicknameRegistrationMessage : NetworkMessage
    {
        public const uint Id = 8878;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public NicknameRegistrationMessage()
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