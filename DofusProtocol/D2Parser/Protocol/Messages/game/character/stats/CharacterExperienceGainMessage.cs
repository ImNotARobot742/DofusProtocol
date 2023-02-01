

// Generated on 02/01/2023 12:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterExperienceGainMessage : NetworkMessage
    {
        public const uint Id = 1383;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double experienceCharacter;
        public double experienceMount;
        public double experienceGuild;
        public double experienceIncarnation;
        
        public CharacterExperienceGainMessage()
        {
        }
        
        public CharacterExperienceGainMessage(double experienceCharacter, double experienceMount, double experienceGuild, double experienceIncarnation)
        {
            this.experienceCharacter = experienceCharacter;
            this.experienceMount = experienceMount;
            this.experienceGuild = experienceGuild;
            this.experienceIncarnation = experienceIncarnation;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(experienceCharacter);
            writer.WriteVarLong(experienceMount);
            writer.WriteVarLong(experienceGuild);
            writer.WriteVarLong(experienceIncarnation);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            experienceCharacter = reader.ReadVarULong();
            experienceMount = reader.ReadVarULong();
            experienceGuild = reader.ReadVarULong();
            experienceIncarnation = reader.ReadVarULong();
        }
        
    }
    
}