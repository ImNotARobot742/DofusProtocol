

// Generated on 02/01/2023 12:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class PlayerNote
    {
        public const short Id = 6851;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public string content;
        public double lastEditDate;
        
        public PlayerNote()
        {
        }
        
        public PlayerNote(string content, double lastEditDate)
        {
            this.content = content;
            this.lastEditDate = lastEditDate;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(content);
            writer.WriteDouble(lastEditDate);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            content = reader.ReadUTF();
            lastEditDate = reader.ReadDouble();
        }
        
    }
    
}