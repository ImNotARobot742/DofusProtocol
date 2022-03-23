

// Generated on 03/23/2022 09:50:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightPlacementSwapPositionsOfferMessage : NetworkMessage
    {
        public const uint Id = 8968;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int requestId;
        public double requesterId;
        public uint requesterCellId;
        public double requestedId;
        public uint requestedCellId;
        
        public GameFightPlacementSwapPositionsOfferMessage()
        {
        }
        
        public GameFightPlacementSwapPositionsOfferMessage(int requestId, double requesterId, uint requesterCellId, double requestedId, uint requestedCellId)
        {
            this.requestId = requestId;
            this.requesterId = requesterId;
            this.requesterCellId = requesterCellId;
            this.requestedId = requestedId;
            this.requestedCellId = requestedCellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(requestId);
            writer.WriteDouble(requesterId);
            writer.WriteVarShort((short)requesterCellId);
            writer.WriteDouble(requestedId);
            writer.WriteVarShort((short)requestedCellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            requestId = reader.ReadInt();
            requesterId = reader.ReadDouble();
            requesterCellId = reader.ReadVarUShort();
            requestedId = reader.ReadDouble();
            requestedCellId = reader.ReadVarUShort();
        }
        
    }
    
}