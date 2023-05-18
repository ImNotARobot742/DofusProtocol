

// Generated on 05/18/2023 15:10:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class InviteInHavenBagOfferMessage : NetworkMessage
    {
        public const uint Id = 2598;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.CharacterMinimalInformations hostInformations;
        public int timeLeftBeforeCancel;
        
        public InviteInHavenBagOfferMessage()
        {
        }
        
        public InviteInHavenBagOfferMessage(Types.CharacterMinimalInformations hostInformations, int timeLeftBeforeCancel)
        {
            this.hostInformations = hostInformations;
            this.timeLeftBeforeCancel = timeLeftBeforeCancel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            hostInformations.Serialize(writer);
            writer.WriteVarInt((int)timeLeftBeforeCancel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            hostInformations = new Types.CharacterMinimalInformations();
            hostInformations.Deserialize(reader);
            timeLeftBeforeCancel = reader.ReadVarInt();
        }
        
    }
    
}