

// Generated on 02/01/2023 12:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AbstractContactInformations
    {
        public const short Id = 7523;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int accountId;
        public Types.AccountTagInformation accountTag;
        
        public AbstractContactInformations()
        {
        }
        
        public AbstractContactInformations(int accountId, Types.AccountTagInformation accountTag)
        {
            this.accountId = accountId;
            this.accountTag = accountTag;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(accountId);
            accountTag.Serialize(writer);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            accountId = reader.ReadInt();
            accountTag = new Types.AccountTagInformation();
            accountTag.Deserialize(reader);
        }
        
    }
    
}