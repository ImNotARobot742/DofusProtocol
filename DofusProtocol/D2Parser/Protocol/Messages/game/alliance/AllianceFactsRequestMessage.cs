

// Generated on 01/01/2022 14:39:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceFactsRequestMessage : NetworkMessage
    {
        public const uint Id = 8146;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint allianceId;
        
        public AllianceFactsRequestMessage()
        {
        }
        
        public AllianceFactsRequestMessage(uint allianceId)
        {
            this.allianceId = allianceId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)allianceId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            allianceId = reader.ReadVarUInt();
        }
        
    }
    
}