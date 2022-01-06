

// Generated on 01/01/2022 14:39:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountReleasedMessage : NetworkMessage
    {
        public const uint Id = 843;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int mountId;
        
        public MountReleasedMessage()
        {
        }
        
        public MountReleasedMessage(int mountId)
        {
            this.mountId = mountId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)mountId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mountId = reader.ReadVarInt();
        }
        
    }
    
}