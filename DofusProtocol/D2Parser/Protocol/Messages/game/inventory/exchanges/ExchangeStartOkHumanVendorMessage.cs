

// Generated on 01/01/2022 14:39:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeStartOkHumanVendorMessage : NetworkMessage
    {
        public const uint Id = 9011;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double sellerId;
        public Types.ObjectItemToSellInHumanVendorShop[] objectsInfos;
        
        public ExchangeStartOkHumanVendorMessage()
        {
        }
        
        public ExchangeStartOkHumanVendorMessage(double sellerId, Types.ObjectItemToSellInHumanVendorShop[] objectsInfos)
        {
            this.sellerId = sellerId;
            this.objectsInfos = objectsInfos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(sellerId);
            writer.WriteShort((short)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            sellerId = reader.ReadDouble();
            var limit = (ushort)reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSellInHumanVendorShop[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItemToSellInHumanVendorShop();
                 objectsInfos[i].Deserialize(reader);
            }
        }
        
    }
    
}