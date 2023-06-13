

// Generated on 06/13/2023 16:59:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyEntityUpdateLightMessage : PartyUpdateLightMessage
    {
        public const uint Id = 2794;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte indexId;
        
        public PartyEntityUpdateLightMessage()
        {
        }
        
        public PartyEntityUpdateLightMessage(uint partyId, double id, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate, sbyte indexId)
         : base(partyId, id, lifePoints, maxLifePoints, prospecting, regenRate)
        {
            this.indexId = indexId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(indexId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            indexId = reader.ReadSbyte();
        }
        
    }
    
}