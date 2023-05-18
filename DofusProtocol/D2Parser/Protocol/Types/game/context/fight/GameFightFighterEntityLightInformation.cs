

// Generated on 05/18/2023 16:29:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightFighterEntityLightInformation : GameFightFighterLightInformations
    {
        public const short Id = 493;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte entityModelId;
        public double masterId;
        
        public GameFightFighterEntityLightInformation()
        {
        }
        
        public GameFightFighterEntityLightInformation(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed, sbyte entityModelId, double masterId)
         : base(sex, alive, id, wave, level, breed)
        {
            this.entityModelId = entityModelId;
            this.masterId = masterId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(entityModelId);
            writer.WriteDouble(masterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            entityModelId = reader.ReadSbyte();
            masterId = reader.ReadDouble();
        }
        
    }
    
}