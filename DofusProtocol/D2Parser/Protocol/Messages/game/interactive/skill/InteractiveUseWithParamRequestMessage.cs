

// Generated on 03/23/2022 09:50:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class InteractiveUseWithParamRequestMessage : InteractiveUseRequestMessage
    {
        public const uint Id = 6428;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int id;
        
        public InteractiveUseWithParamRequestMessage()
        {
        }
        
        public InteractiveUseWithParamRequestMessage(uint elemId, uint skillInstanceUid, int id)
         : base(elemId, skillInstanceUid)
        {
            this.id = id;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(id);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            id = reader.ReadInt();
        }
        
    }
    
}