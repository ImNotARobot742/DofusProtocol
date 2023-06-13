

// Generated on 06/13/2023 16:59:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MultiTabStorageMessage : NetworkMessage
    {
        public const uint Id = 2145;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.StorageTabInformation[] tabs;
        
        public MultiTabStorageMessage()
        {
        }
        
        public MultiTabStorageMessage(Types.StorageTabInformation[] tabs)
        {
            this.tabs = tabs;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)tabs.Length);
            foreach (var entry in tabs)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            tabs = new Types.StorageTabInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 tabs[i] = new Types.StorageTabInformation();
                 tabs[i].Deserialize(reader);
            }
        }
        
    }
    
}