

// Generated on 06/13/2023 16:59:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectAveragePricesMessage : NetworkMessage
    {
        public const uint Id = 1712;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] ids;
        public double[] avgPrices;
        
        public ObjectAveragePricesMessage()
        {
        }
        
        public ObjectAveragePricesMessage(uint[] ids, double[] avgPrices)
        {
            this.ids = ids;
            this.avgPrices = avgPrices;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)avgPrices.Length);
            foreach (var entry in avgPrices)
            {
                 writer.WriteVarLong(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            ids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadVarUInt();
            }
            limit = (ushort)reader.ReadUShort();
            avgPrices = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 avgPrices[i] = reader.ReadVarULong();
            }
        }
        
    }
    
}