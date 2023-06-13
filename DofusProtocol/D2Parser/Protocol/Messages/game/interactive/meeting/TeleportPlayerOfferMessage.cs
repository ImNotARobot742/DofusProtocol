

// Generated on 06/13/2023 16:59:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TeleportPlayerOfferMessage : NetworkMessage
    {
        public const uint Id = 5557;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double mapId;
        public string message;
        public uint timeLeft;
        public double requesterId;
        
        public TeleportPlayerOfferMessage()
        {
        }
        
        public TeleportPlayerOfferMessage(double mapId, string message, uint timeLeft, double requesterId)
        {
            this.mapId = mapId;
            this.message = message;
            this.timeLeft = timeLeft;
            this.requesterId = requesterId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(mapId);
            writer.WriteUTF(message);
            writer.WriteVarInt((int)timeLeft);
            writer.WriteVarLong(requesterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mapId = reader.ReadDouble();
            message = reader.ReadUTF();
            timeLeft = reader.ReadVarUInt();
            requesterId = reader.ReadVarULong();
        }
        
    }
    
}