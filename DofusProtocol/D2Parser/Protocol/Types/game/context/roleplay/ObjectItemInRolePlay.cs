

// Generated on 02/01/2023 12:54:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ObjectItemInRolePlay
    {
        public const short Id = 572;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint cellId;
        public uint objectGID;
        
        public ObjectItemInRolePlay()
        {
        }
        
        public ObjectItemInRolePlay(uint cellId, uint objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)cellId);
            writer.WriteVarShort((short)objectGID);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            cellId = reader.ReadVarUShort();
            objectGID = reader.ReadVarUShort();
        }
        
    }
    
}