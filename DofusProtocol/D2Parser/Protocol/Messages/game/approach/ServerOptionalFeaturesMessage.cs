

// Generated on 03/23/2022 09:50:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ServerOptionalFeaturesMessage : NetworkMessage
    {
        public const uint Id = 7447;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int[] features;
        
        public ServerOptionalFeaturesMessage()
        {
        }
        
        public ServerOptionalFeaturesMessage(int[] features)
        {
            this.features = features;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)features.Length);
            foreach (var entry in features)
            {
                 writer.WriteInt(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            features = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 features[i] = reader.ReadInt();
            }
        }
        
    }
    
}