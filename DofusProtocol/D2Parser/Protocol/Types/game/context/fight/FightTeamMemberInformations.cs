

// Generated on 06/13/2023 17:00:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightTeamMemberInformations
    {
        public const short Id = 4909;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double id;
        
        public FightTeamMemberInformations()
        {
        }
        
        public FightTeamMemberInformations(double id)
        {
            this.id = id;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(id);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadDouble();
        }
        
    }
    
}