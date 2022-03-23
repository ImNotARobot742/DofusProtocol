

// Generated on 03/23/2022 09:50:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StorageObjectsRemoveMessage : NetworkMessage
    {
        public const uint Id = 9509;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] objectUIDList;
        
        public StorageObjectsRemoveMessage()
        {
        }
        
        public StorageObjectsRemoveMessage(uint[] objectUIDList)
        {
            this.objectUIDList = objectUIDList;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)objectUIDList.Length);
            foreach (var entry in objectUIDList)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            objectUIDList = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectUIDList[i] = reader.ReadVarUInt();
            }
        }
        
    }
    
}