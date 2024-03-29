

// Generated on 06/13/2023 16:59:53
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeStartedTaxCollectorShopMessage : NetworkMessage
    {
        public const uint Id = 5688;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ObjectItem[] objects;
        public double kamas;
        
        public ExchangeStartedTaxCollectorShopMessage()
        {
        }
        
        public ExchangeStartedTaxCollectorShopMessage(Types.ObjectItem[] objects, double kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarLong(kamas);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.ObjectItem();
                 objects[i].Deserialize(reader);
            }
            kamas = reader.ReadVarULong();
        }
        
    }
    
}