

// Generated on 03/23/2022 09:51:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AdditionalTaxCollectorInformations
    {
        public const short Id = 1493;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public string collectorCallerName;
        public int date;
        
        public AdditionalTaxCollectorInformations()
        {
        }
        
        public AdditionalTaxCollectorInformations(string collectorCallerName, int date)
        {
            this.collectorCallerName = collectorCallerName;
            this.date = date;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(collectorCallerName);
            writer.WriteInt(date);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            collectorCallerName = reader.ReadUTF();
            date = reader.ReadInt();
        }
        
    }
    
}