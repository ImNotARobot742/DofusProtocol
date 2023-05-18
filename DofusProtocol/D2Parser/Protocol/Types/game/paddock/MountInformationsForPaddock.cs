

// Generated on 05/18/2023 16:29:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class MountInformationsForPaddock
    {
        public const short Id = 7765;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint modelId;
        public string name;
        public string ownerName;
        
        public MountInformationsForPaddock()
        {
        }
        
        public MountInformationsForPaddock(uint modelId, string name, string ownerName)
        {
            this.modelId = modelId;
            this.name = name;
            this.ownerName = ownerName;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)modelId);
            writer.WriteUTF(name);
            writer.WriteUTF(ownerName);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            modelId = reader.ReadVarUShort();
            name = reader.ReadUTF();
            ownerName = reader.ReadUTF();
        }
        
    }
    
}