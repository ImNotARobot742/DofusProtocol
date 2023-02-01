

// Generated on 02/01/2023 12:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyUpdateLightMessage : AbstractPartyEventMessage
    {
        public const uint Id = 8058;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double id;
        public uint lifePoints;
        public uint maxLifePoints;
        public uint prospecting;
        public byte regenRate;
        
        public PartyUpdateLightMessage()
        {
        }
        
        public PartyUpdateLightMessage(uint partyId, double id, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate)
         : base(partyId)
        {
            this.id = id;
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.prospecting = prospecting;
            this.regenRate = regenRate;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(id);
            writer.WriteVarInt((int)lifePoints);
            writer.WriteVarInt((int)maxLifePoints);
            writer.WriteVarShort((short)prospecting);
            writer.WriteByte(regenRate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            id = reader.ReadVarULong();
            lifePoints = reader.ReadVarUInt();
            maxLifePoints = reader.ReadVarUInt();
            prospecting = reader.ReadVarUShort();
            regenRate = reader.ReadByte();
        }
        
    }
    
}