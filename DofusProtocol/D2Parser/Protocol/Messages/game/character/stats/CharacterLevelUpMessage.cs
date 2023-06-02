

// Generated on 06/02/2023 19:00:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterLevelUpMessage : NetworkMessage
    {
        public const uint Id = 3888;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint newLevel;
        
        public CharacterLevelUpMessage()
        {
        }
        
        public CharacterLevelUpMessage(uint newLevel)
        {
            this.newLevel = newLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)newLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            newLevel = reader.ReadVarUShort();
        }
        
    }
    
}