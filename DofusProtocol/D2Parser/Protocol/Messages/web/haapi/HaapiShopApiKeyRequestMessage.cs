

// Generated on 02/01/2023 12:53:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiShopApiKeyRequestMessage : NetworkMessage
    {
        public const uint Id = 950;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public HaapiShopApiKeyRequestMessage()
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