

// Generated on 03/23/2022 09:50:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseSellingUpdateMessage : NetworkMessage
    {
        public const uint Id = 9319;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint houseId;
        public int instanceId;
        public bool secondHand;
        public double realPrice;
        public Types.AccountTagInformation buyerTag;
        
        public HouseSellingUpdateMessage()
        {
        }
        
        public HouseSellingUpdateMessage(uint houseId, int instanceId, bool secondHand, double realPrice, Types.AccountTagInformation buyerTag)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.realPrice = realPrice;
            this.buyerTag = buyerTag;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
            writer.WriteBoolean(secondHand);
            writer.WriteVarLong(realPrice);
            buyerTag.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            houseId = reader.ReadVarUInt();
            instanceId = reader.ReadInt();
            secondHand = reader.ReadBoolean();
            realPrice = reader.ReadVarULong();
            buyerTag = new Types.AccountTagInformation();
            buyerTag.Deserialize(reader);
        }
        
    }
    
}