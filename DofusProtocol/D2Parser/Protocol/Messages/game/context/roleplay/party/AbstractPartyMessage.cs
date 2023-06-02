

// Generated on 06/02/2023 19:00:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AbstractPartyMessage : NetworkMessage
    {
        public const uint Id = 7545;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint partyId;
        
        public AbstractPartyMessage()
        {
        }
        
        public AbstractPartyMessage(uint partyId)
        {
            this.partyId = partyId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)partyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            partyId = reader.ReadVarUInt();
        }
        
    }
    
}