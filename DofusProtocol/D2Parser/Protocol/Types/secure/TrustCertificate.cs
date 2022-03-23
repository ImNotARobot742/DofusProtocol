

// Generated on 03/23/2022 09:51:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TrustCertificate
    {
        public const short Id = 8303;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int id;
        public string hash;
        
        public TrustCertificate()
        {
        }
        
        public TrustCertificate(int id, string hash)
        {
            this.id = id;
            this.hash = hash;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(id);
            writer.WriteUTF(hash);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadInt();
            hash = reader.ReadUTF();
        }
        
    }
    
}