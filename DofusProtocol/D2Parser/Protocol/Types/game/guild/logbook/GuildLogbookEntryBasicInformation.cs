

// Generated on 05/18/2023 16:29:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildLogbookEntryBasicInformation
    {
        public const short Id = 8461;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint id;
        public double date;
        
        public GuildLogbookEntryBasicInformation()
        {
        }
        
        public GuildLogbookEntryBasicInformation(uint id, double date)
        {
            this.id = id;
            this.date = date;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)id);
            writer.WriteDouble(date);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUInt();
            date = reader.ReadDouble();
        }
        
    }
    
}