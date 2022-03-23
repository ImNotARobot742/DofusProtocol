

// Generated on 03/23/2022 09:50:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeStartOkNpcShopMessage : NetworkMessage
    {
        public const uint Id = 3711;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double npcSellerId;
        public uint tokenId;
        public Types.ObjectItemToSellInNpcShop[] objectsInfos;
        
        public ExchangeStartOkNpcShopMessage()
        {
        }
        
        public ExchangeStartOkNpcShopMessage(double npcSellerId, uint tokenId, Types.ObjectItemToSellInNpcShop[] objectsInfos)
        {
            this.npcSellerId = npcSellerId;
            this.tokenId = tokenId;
            this.objectsInfos = objectsInfos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(npcSellerId);
            writer.WriteVarShort((short)tokenId);
            writer.WriteShort((short)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            npcSellerId = reader.ReadDouble();
            tokenId = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSellInNpcShop[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItemToSellInNpcShop();
                 objectsInfos[i].Deserialize(reader);
            }
        }
        
    }
    
}