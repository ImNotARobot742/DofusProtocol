

// Generated on 06/02/2023 19:00:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ArenaFighterLeaveMessage : NetworkMessage
    {
        public const uint Id = 4191;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.CharacterBasicMinimalInformations leaver;
        
        public ArenaFighterLeaveMessage()
        {
        }
        
        public ArenaFighterLeaveMessage(Types.CharacterBasicMinimalInformations leaver)
        {
            this.leaver = leaver;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            leaver.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            leaver = new Types.CharacterBasicMinimalInformations();
            leaver.Deserialize(reader);
        }
        
    }
    
}