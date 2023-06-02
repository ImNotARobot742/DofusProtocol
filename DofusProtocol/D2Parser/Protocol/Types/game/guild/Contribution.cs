

// Generated on 06/02/2023 19:01:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class Contribution
    {
        public const short Id = 6353;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double contributorId;
        public string contributorName;
        public double amount;
        
        public Contribution()
        {
        }
        
        public Contribution(double contributorId, string contributorName, double amount)
        {
            this.contributorId = contributorId;
            this.contributorName = contributorName;
            this.amount = amount;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(contributorId);
            writer.WriteUTF(contributorName);
            writer.WriteVarLong(amount);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            contributorId = reader.ReadVarULong();
            contributorName = reader.ReadUTF();
            amount = reader.ReadVarULong();
        }
        
    }
    
}