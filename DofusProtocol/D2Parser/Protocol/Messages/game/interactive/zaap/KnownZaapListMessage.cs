

// Generated on 03/23/2022 09:50:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class KnownZaapListMessage : NetworkMessage
    {
        public const uint Id = 1272;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double[] destinations;
        
        public KnownZaapListMessage()
        {
        }
        
        public KnownZaapListMessage(double[] destinations)
        {
            this.destinations = destinations;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)destinations.Length);
            foreach (var entry in destinations)
            {
                 writer.WriteDouble(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            destinations = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 destinations[i] = reader.ReadDouble();
            }
        }
        
    }
    
}