

// Generated on 03/23/2022 09:50:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class EntityInformationMessage : NetworkMessage
    {
        public const uint Id = 6691;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.EntityInformation entity;
        
        public EntityInformationMessage()
        {
        }
        
        public EntityInformationMessage(Types.EntityInformation entity)
        {
            this.entity = entity;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            entity.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            entity = new Types.EntityInformation();
            entity.Deserialize(reader);
        }
        
    }
    
}