

// Generated on 02/01/2023 12:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeStartOkMountWithOutPaddockMessage : NetworkMessage
    {
        public const uint Id = 257;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.MountClientData[] stabledMountsDescription;
        
        public ExchangeStartOkMountWithOutPaddockMessage()
        {
        }
        
        public ExchangeStartOkMountWithOutPaddockMessage(Types.MountClientData[] stabledMountsDescription)
        {
            this.stabledMountsDescription = stabledMountsDescription;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)stabledMountsDescription.Length);
            foreach (var entry in stabledMountsDescription)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            stabledMountsDescription = new Types.MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 stabledMountsDescription[i] = new Types.MountClientData();
                 stabledMountsDescription[i].Deserialize(reader);
            }
        }
        
    }
    
}