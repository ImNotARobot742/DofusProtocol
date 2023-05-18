

// Generated on 05/18/2023 15:10:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendsListMessage : NetworkMessage
    {
        public const uint Id = 9831;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.FriendInformations[] friendsList;
        
        public FriendsListMessage()
        {
        }
        
        public FriendsListMessage(Types.FriendInformations[] friendsList)
        {
            this.friendsList = friendsList;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)friendsList.Length);
            foreach (var entry in friendsList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            friendsList = new Types.FriendInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 friendsList[i] = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadUShort());
                 friendsList[i].Deserialize(reader);
            }
        }
        
    }
    
}