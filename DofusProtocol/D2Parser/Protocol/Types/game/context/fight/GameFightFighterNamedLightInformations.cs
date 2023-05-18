

// Generated on 05/18/2023 16:29:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightFighterNamedLightInformations : GameFightFighterLightInformations
    {
        public const short Id = 7583;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public string name;
        
        public GameFightFighterNamedLightInformations()
        {
        }
        
        public GameFightFighterNamedLightInformations(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed, string name)
         : base(sex, alive, id, wave, level, breed)
        {
            this.name = name;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            name = reader.ReadUTF();
        }
        
    }
    
}