

// Generated on 06/13/2023 17:00:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AccountTagInformation
    {
        public const short Id = 1835;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public string nickname;
        public string tagNumber;
        
        public AccountTagInformation()
        {
        }
        
        public AccountTagInformation(string nickname, string tagNumber)
        {
            this.nickname = nickname;
            this.tagNumber = tagNumber;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(nickname);
            writer.WriteUTF(tagNumber);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            nickname = reader.ReadUTF();
            tagNumber = reader.ReadUTF();
        }
        
    }
    
}