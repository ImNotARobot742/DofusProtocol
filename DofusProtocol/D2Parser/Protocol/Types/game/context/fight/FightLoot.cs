

// Generated on 06/13/2023 17:00:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightLoot
    {
        public const short Id = 9670;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public Types.FightLootObject[] objects;
        public double kamas;
        
        public FightLoot()
        {
        }
        
        public FightLoot(Types.FightLootObject[] objects, double kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarLong(kamas);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            objects = new Types.FightLootObject[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.FightLootObject();
                 objects[i].Deserialize(reader);
            }
            kamas = reader.ReadVarULong();
        }
        
    }
    
}