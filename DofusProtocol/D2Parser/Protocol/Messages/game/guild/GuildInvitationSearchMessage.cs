

// Generated on 03/23/2022 09:50:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildInvitationSearchMessage : NetworkMessage
    {
        public const uint Id = 756;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AbstractPlayerSearchInformation target;
        
        public GuildInvitationSearchMessage()
        {
        }
        
        public GuildInvitationSearchMessage(Types.AbstractPlayerSearchInformation target)
        {
            this.target = target;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(target.TypeId);
            target.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
        }
        
    }
    
}