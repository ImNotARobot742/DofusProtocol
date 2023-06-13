

// Generated on 06/13/2023 16:59:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectGroundListAddedMessage : NetworkMessage
    {
        public const uint Id = 859;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] cells;
        public uint[] referenceIds;
        
        public ObjectGroundListAddedMessage()
        {
        }
        
        public ObjectGroundListAddedMessage(uint[] cells, uint[] referenceIds)
        {
            this.cells = cells;
            this.referenceIds = referenceIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)cells.Length);
            foreach (var entry in cells)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteShort((short)referenceIds.Length);
            foreach (var entry in referenceIds)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            cells = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 cells[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadUShort();
            referenceIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 referenceIds[i] = reader.ReadVarUInt();
            }
        }
        
    }
    
}