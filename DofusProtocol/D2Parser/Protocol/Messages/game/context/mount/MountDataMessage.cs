

// Generated on 06/02/2023 19:00:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountDataMessage : NetworkMessage
    {
        public const uint Id = 8791;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.MountClientData mountData;
        
        public MountDataMessage()
        {
        }
        
        public MountDataMessage(Types.MountClientData mountData)
        {
            this.mountData = mountData;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            mountData.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mountData = new Types.MountClientData();
            mountData.Deserialize(reader);
        }
        
    }
    
}