

// Generated on 06/13/2023 16:59:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MigratedServerListMessage : NetworkMessage
    {
        public const uint Id = 3249;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] migratedServerIds;
        
        public MigratedServerListMessage()
        {
        }
        
        public MigratedServerListMessage(uint[] migratedServerIds)
        {
            this.migratedServerIds = migratedServerIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)migratedServerIds.Length);
            foreach (var entry in migratedServerIds)
            {
                 writer.WriteVarShort((short)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            migratedServerIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 migratedServerIds[i] = reader.ReadVarUShort();
            }
        }
        
    }
    
}