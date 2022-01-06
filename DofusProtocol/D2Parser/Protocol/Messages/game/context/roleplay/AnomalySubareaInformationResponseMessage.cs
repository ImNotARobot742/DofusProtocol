

// Generated on 01/01/2022 14:39:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AnomalySubareaInformationResponseMessage : NetworkMessage
    {
        public const uint Id = 6030;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AnomalySubareaInformation[] subareas;
        
        public AnomalySubareaInformationResponseMessage()
        {
        }
        
        public AnomalySubareaInformationResponseMessage(Types.AnomalySubareaInformation[] subareas)
        {
            this.subareas = subareas;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)subareas.Length);
            foreach (var entry in subareas)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            subareas = new Types.AnomalySubareaInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 subareas[i] = new Types.AnomalySubareaInformation();
                 subareas[i].Deserialize(reader);
            }
        }
        
    }
    
}