

// Generated on 05/18/2023 16:29:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class StorageTabInformation
    {
        public const short Id = 2008;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public string name;
        public uint tabNumber;
        public uint picto;
        public uint openRight;
        public uint dropRight;
        public uint takeRight;
        public uint[] dropTypeLimitation;
        
        public StorageTabInformation()
        {
        }
        
        public StorageTabInformation(string name, uint tabNumber, uint picto, uint openRight, uint dropRight, uint takeRight, uint[] dropTypeLimitation)
        {
            this.name = name;
            this.tabNumber = tabNumber;
            this.picto = picto;
            this.openRight = openRight;
            this.dropRight = dropRight;
            this.takeRight = takeRight;
            this.dropTypeLimitation = dropTypeLimitation;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(name);
            writer.WriteVarInt((int)tabNumber);
            writer.WriteVarInt((int)picto);
            writer.WriteVarInt((int)openRight);
            writer.WriteVarInt((int)dropRight);
            writer.WriteVarInt((int)takeRight);
            writer.WriteShort((short)dropTypeLimitation.Length);
            foreach (var entry in dropTypeLimitation)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            name = reader.ReadUTF();
            tabNumber = reader.ReadVarUInt();
            picto = reader.ReadVarUInt();
            openRight = reader.ReadVarUInt();
            dropRight = reader.ReadVarUInt();
            takeRight = reader.ReadVarUInt();
            var limit = (ushort)reader.ReadUShort();
            dropTypeLimitation = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 dropTypeLimitation[i] = reader.ReadVarUInt();
            }
        }
        
    }
    
}