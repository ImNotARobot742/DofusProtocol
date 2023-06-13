

// Generated on 06/13/2023 16:59:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DungeonKeyRingMessage : NetworkMessage
    {
        public const uint Id = 6772;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] availables;
        public uint[] unavailables;
        
        public DungeonKeyRingMessage()
        {
        }
        
        public DungeonKeyRingMessage(uint[] availables, uint[] unavailables)
        {
            this.availables = availables;
            this.unavailables = unavailables;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)availables.Length);
            foreach (var entry in availables)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteShort((short)unavailables.Length);
            foreach (var entry in unavailables)
            {
                 writer.WriteVarShort((short)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            availables = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 availables[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadUShort();
            unavailables = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 unavailables[i] = reader.ReadVarUShort();
            }
        }
        
    }
    
}