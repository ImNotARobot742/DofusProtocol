

// Generated on 06/13/2023 16:59:53
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeStartedMountStockMessage : NetworkMessage
    {
        public const uint Id = 8511;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ObjectItem[] objectsInfos;
        
        public ExchangeStartedMountStockMessage()
        {
        }
        
        public ExchangeStartedMountStockMessage(Types.ObjectItem[] objectsInfos)
        {
            this.objectsInfos = objectsInfos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            objectsInfos = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItem();
                 objectsInfos[i].Deserialize(reader);
            }
        }
        
    }
    
}