

// Generated on 01/01/2022 14:40:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ItemForPreset
    {
        public const short Id = 4107;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public short position;
        public uint objGid;
        public uint objUid;
        
        public ItemForPreset()
        {
        }
        
        public ItemForPreset(short position, uint objGid, uint objUid)
        {
            this.position = position;
            this.objGid = objGid;
            this.objUid = objUid;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort(position);
            writer.WriteVarShort((short)objGid);
            writer.WriteVarInt((int)objUid);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            position = reader.ReadShort();
            objGid = reader.ReadVarUShort();
            objUid = reader.ReadVarUInt();
        }
        
    }
    
}