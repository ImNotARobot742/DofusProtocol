

// Generated on 02/01/2023 12:53:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightFighterTaxCollectorLightInformations : GameFightFighterLightInformations
    {
        public const short Id = 55;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint firstNameId;
        public uint lastNameId;
        
        public GameFightFighterTaxCollectorLightInformations()
        {
        }
        
        public GameFightFighterTaxCollectorLightInformations(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed, uint firstNameId, uint lastNameId)
         : base(sex, alive, id, wave, level, breed)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)firstNameId);
            writer.WriteVarShort((short)lastNameId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            firstNameId = reader.ReadVarUShort();
            lastNameId = reader.ReadVarUShort();
        }
        
    }
    
}