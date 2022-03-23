

// Generated on 03/23/2022 09:50:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeMountsStableAddMessage : NetworkMessage
    {
        public const uint Id = 3365;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.MountClientData[] mountDescription;
        
        public ExchangeMountsStableAddMessage()
        {
        }
        
        public ExchangeMountsStableAddMessage(Types.MountClientData[] mountDescription)
        {
            this.mountDescription = mountDescription;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)mountDescription.Length);
            foreach (var entry in mountDescription)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            mountDescription = new Types.MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 mountDescription[i] = new Types.MountClientData();
                 mountDescription[i].Deserialize(reader);
            }
        }
        
    }
    
}