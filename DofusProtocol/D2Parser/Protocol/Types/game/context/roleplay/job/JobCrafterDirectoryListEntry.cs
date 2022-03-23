

// Generated on 03/23/2022 09:51:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class JobCrafterDirectoryListEntry
    {
        public const short Id = 2849;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public Types.JobCrafterDirectoryEntryPlayerInfo playerInfo;
        public Types.JobCrafterDirectoryEntryJobInfo jobInfo;
        
        public JobCrafterDirectoryListEntry()
        {
        }
        
        public JobCrafterDirectoryListEntry(Types.JobCrafterDirectoryEntryPlayerInfo playerInfo, Types.JobCrafterDirectoryEntryJobInfo jobInfo)
        {
            this.playerInfo = playerInfo;
            this.jobInfo = jobInfo;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            playerInfo.Serialize(writer);
            jobInfo.Serialize(writer);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            playerInfo = new Types.JobCrafterDirectoryEntryPlayerInfo();
            playerInfo.Deserialize(reader);
            jobInfo = new Types.JobCrafterDirectoryEntryJobInfo();
            jobInfo.Deserialize(reader);
        }
        
    }
    
}