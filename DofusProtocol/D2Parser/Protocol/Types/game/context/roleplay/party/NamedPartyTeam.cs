

// Generated on 01/01/2022 14:40:05
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class NamedPartyTeam
    {
        public const short Id = 6995;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public sbyte teamId;
        public string partyName;
        
        public NamedPartyTeam()
        {
        }
        
        public NamedPartyTeam(sbyte teamId, string partyName)
        {
            this.teamId = teamId;
            this.partyName = partyName;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(teamId);
            writer.WriteUTF(partyName);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            teamId = reader.ReadSbyte();
            partyName = reader.ReadUTF();
        }
        
    }
    
}