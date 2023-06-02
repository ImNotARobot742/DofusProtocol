

// Generated on 06/02/2023 19:00:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendUpdateMessage : NetworkMessage
    {
        public const uint Id = 6876;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.FriendInformations friendUpdated;
        
        public FriendUpdateMessage()
        {
        }
        
        public FriendUpdateMessage(Types.FriendInformations friendUpdated)
        {
            this.friendUpdated = friendUpdated;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(friendUpdated.TypeId);
            friendUpdated.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            friendUpdated = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadUShort());
            friendUpdated.Deserialize(reader);
        }
        
    }
    
}