

// Generated on 06/02/2023 19:00:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterLevelUpInformationMessage : CharacterLevelUpMessage
    {
        public const uint Id = 4362;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string name;
        public double id;
        
        public CharacterLevelUpInformationMessage()
        {
        }
        
        public CharacterLevelUpInformationMessage(uint newLevel, string name, double id)
         : base(newLevel)
        {
            this.name = name;
            this.id = id;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVarLong(id);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            name = reader.ReadUTF();
            id = reader.ReadVarULong();
        }
        
    }
    
}