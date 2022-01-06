

// Generated on 01/01/2022 14:39:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class EvolutiveObjectRecycleResultMessage : NetworkMessage
    {
        public const uint Id = 8805;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.RecycledItem[] recycledItems;
        
        public EvolutiveObjectRecycleResultMessage()
        {
        }
        
        public EvolutiveObjectRecycleResultMessage(Types.RecycledItem[] recycledItems)
        {
            this.recycledItems = recycledItems;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)recycledItems.Length);
            foreach (var entry in recycledItems)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            recycledItems = new Types.RecycledItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 recycledItems[i] = new Types.RecycledItem();
                 recycledItems[i].Deserialize(reader);
            }
        }
        
    }
    
}