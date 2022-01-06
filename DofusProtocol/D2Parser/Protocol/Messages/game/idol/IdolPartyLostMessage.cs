

// Generated on 01/01/2022 14:39:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IdolPartyLostMessage : NetworkMessage
    {
        public const uint Id = 7502;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint idolId;
        
        public IdolPartyLostMessage()
        {
        }
        
        public IdolPartyLostMessage(uint idolId)
        {
            this.idolId = idolId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)idolId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            idolId = reader.ReadVarUShort();
        }
        
    }
    
}