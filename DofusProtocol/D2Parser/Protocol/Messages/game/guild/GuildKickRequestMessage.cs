

// Generated on 02/01/2023 12:53:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildKickRequestMessage : NetworkMessage
    {
        public const uint Id = 983;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double kickedId;
        
        public GuildKickRequestMessage()
        {
        }
        
        public GuildKickRequestMessage(double kickedId)
        {
            this.kickedId = kickedId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(kickedId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            kickedId = reader.ReadVarULong();
        }
        
    }
    
}