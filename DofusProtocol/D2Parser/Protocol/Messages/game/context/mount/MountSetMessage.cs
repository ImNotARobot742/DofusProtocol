

// Generated on 06/02/2023 19:00:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountSetMessage : NetworkMessage
    {
        public const uint Id = 2783;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.MountClientData mountData;
        
        public MountSetMessage()
        {
        }
        
        public MountSetMessage(Types.MountClientData mountData)
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