

// Generated on 01/01/2022 14:39:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildHouseUpdateInformationMessage : NetworkMessage
    {
        public const uint Id = 6703;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.HouseInformationsForGuild housesInformations;
        
        public GuildHouseUpdateInformationMessage()
        {
        }
        
        public GuildHouseUpdateInformationMessage(Types.HouseInformationsForGuild housesInformations)
        {
            this.housesInformations = housesInformations;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            housesInformations.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            housesInformations = new Types.HouseInformationsForGuild();
            housesInformations.Deserialize(reader);
        }
        
    }
    
}