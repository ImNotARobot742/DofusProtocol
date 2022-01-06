

// Generated on 01/01/2022 14:39:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HavenBagPermissionsUpdateRequestMessage : NetworkMessage
    {
        public const uint Id = 2106;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int permissions;
        
        public HavenBagPermissionsUpdateRequestMessage()
        {
        }
        
        public HavenBagPermissionsUpdateRequestMessage(int permissions)
        {
            this.permissions = permissions;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(permissions);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            permissions = reader.ReadInt();
        }
        
    }
    
}