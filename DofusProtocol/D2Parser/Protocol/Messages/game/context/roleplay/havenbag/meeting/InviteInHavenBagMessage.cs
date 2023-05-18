

// Generated on 05/18/2023 15:10:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class InviteInHavenBagMessage : NetworkMessage
    {
        public const uint Id = 2690;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.CharacterMinimalInformations guestInformations;
        public bool accept;
        
        public InviteInHavenBagMessage()
        {
        }
        
        public InviteInHavenBagMessage(Types.CharacterMinimalInformations guestInformations, bool accept)
        {
            this.guestInformations = guestInformations;
            this.accept = accept;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            guestInformations.Serialize(writer);
            writer.WriteBoolean(accept);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            guestInformations = new Types.CharacterMinimalInformations();
            guestInformations.Deserialize(reader);
            accept = reader.ReadBoolean();
        }
        
    }
    
}