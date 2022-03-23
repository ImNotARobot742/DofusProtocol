

// Generated on 03/23/2022 09:50:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class JobCrafterDirectoryAddMessage : NetworkMessage
    {
        public const uint Id = 4101;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.JobCrafterDirectoryListEntry listEntry;
        
        public JobCrafterDirectoryAddMessage()
        {
        }
        
        public JobCrafterDirectoryAddMessage(Types.JobCrafterDirectoryListEntry listEntry)
        {
            this.listEntry = listEntry;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            listEntry.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            listEntry = new Types.JobCrafterDirectoryListEntry();
            listEntry.Deserialize(reader);
        }
        
    }
    
}