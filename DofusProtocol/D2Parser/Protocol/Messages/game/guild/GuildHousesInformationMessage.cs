

// Generated on 01/01/2022 14:39:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildHousesInformationMessage : NetworkMessage
    {
        public const uint Id = 9308;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.HouseInformationsForGuild[] housesInformations;
        
        public GuildHousesInformationMessage()
        {
        }
        
        public GuildHousesInformationMessage(Types.HouseInformationsForGuild[] housesInformations)
        {
            this.housesInformations = housesInformations;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)housesInformations.Length);
            foreach (var entry in housesInformations)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            housesInformations = new Types.HouseInformationsForGuild[limit];
            for (int i = 0; i < limit; i++)
            {
                 housesInformations[i] = new Types.HouseInformationsForGuild();
                 housesInformations[i].Deserialize(reader);
            }
        }
        
    }
    
}