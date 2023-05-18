

// Generated on 05/18/2023 16:28:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachKickResponseMessage : NetworkMessage
    {
        public const uint Id = 1093;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.CharacterMinimalInformations target;
        public bool kicked;
        
        public BreachKickResponseMessage()
        {
        }
        
        public BreachKickResponseMessage(Types.CharacterMinimalInformations target, bool kicked)
        {
            this.target = target;
            this.kicked = kicked;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            target.Serialize(writer);
            writer.WriteBoolean(kicked);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            target = new Types.CharacterMinimalInformations();
            target.Deserialize(reader);
            kicked = reader.ReadBoolean();
        }
        
    }
    
}