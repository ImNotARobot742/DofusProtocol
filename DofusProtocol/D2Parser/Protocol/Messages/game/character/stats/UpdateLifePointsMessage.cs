

// Generated on 05/18/2023 15:10:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class UpdateLifePointsMessage : NetworkMessage
    {
        public const uint Id = 5126;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint lifePoints;
        public uint maxLifePoints;
        
        public UpdateLifePointsMessage()
        {
        }
        
        public UpdateLifePointsMessage(uint lifePoints, uint maxLifePoints)
        {
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)lifePoints);
            writer.WriteVarInt((int)maxLifePoints);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            lifePoints = reader.ReadVarUInt();
            maxLifePoints = reader.ReadVarUInt();
        }
        
    }
    
}