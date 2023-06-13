

// Generated on 06/13/2023 16:59:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildFightTakePlaceRequestMessage : GuildFightJoinRequestMessage
    {
        public const uint Id = 559;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double replacedCharacterId;
        
        public GuildFightTakePlaceRequestMessage()
        {
        }
        
        public GuildFightTakePlaceRequestMessage(double taxCollectorId, double replacedCharacterId)
         : base(taxCollectorId)
        {
            this.replacedCharacterId = replacedCharacterId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(replacedCharacterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            replacedCharacterId = reader.ReadVarULong();
        }
        
    }
    
}