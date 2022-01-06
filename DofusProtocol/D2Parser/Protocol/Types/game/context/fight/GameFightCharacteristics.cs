

// Generated on 01/01/2022 14:40:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightCharacteristics
    {
        public const short Id = 7425;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public Types.CharacterCharacteristics characteristics;
        public double summoner;
        public bool summoned;
        public sbyte invisibilityState;
        
        public GameFightCharacteristics()
        {
        }
        
        public GameFightCharacteristics(Types.CharacterCharacteristics characteristics, double summoner, bool summoned, sbyte invisibilityState)
        {
            this.characteristics = characteristics;
            this.summoner = summoner;
            this.summoned = summoned;
            this.invisibilityState = invisibilityState;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            characteristics.Serialize(writer);
            writer.WriteDouble(summoner);
            writer.WriteBoolean(summoned);
            writer.WriteSbyte(invisibilityState);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            characteristics = new Types.CharacterCharacteristics();
            characteristics.Deserialize(reader);
            summoner = reader.ReadDouble();
            summoned = reader.ReadBoolean();
            invisibilityState = reader.ReadSbyte();
        }
        
    }
    
}