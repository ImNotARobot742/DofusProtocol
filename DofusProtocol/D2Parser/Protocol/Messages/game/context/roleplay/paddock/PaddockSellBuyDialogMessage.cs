

// Generated on 05/18/2023 16:28:52
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PaddockSellBuyDialogMessage : NetworkMessage
    {
        public const uint Id = 3203;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool bsell;
        public uint ownerId;
        public double price;
        
        public PaddockSellBuyDialogMessage()
        {
        }
        
        public PaddockSellBuyDialogMessage(bool bsell, uint ownerId, double price)
        {
            this.bsell = bsell;
            this.ownerId = ownerId;
            this.price = price;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(bsell);
            writer.WriteVarInt((int)ownerId);
            writer.WriteVarLong(price);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            bsell = reader.ReadBoolean();
            ownerId = reader.ReadVarUInt();
            price = reader.ReadVarULong();
        }
        
    }
    
}