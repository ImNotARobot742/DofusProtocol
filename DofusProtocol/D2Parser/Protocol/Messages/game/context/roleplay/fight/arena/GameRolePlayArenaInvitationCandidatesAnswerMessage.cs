

// Generated on 01/01/2022 14:39:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayArenaInvitationCandidatesAnswerMessage : NetworkMessage
    {
        public const uint Id = 4913;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.LeagueFriendInformations[] candidates;
        
        public GameRolePlayArenaInvitationCandidatesAnswerMessage()
        {
        }
        
        public GameRolePlayArenaInvitationCandidatesAnswerMessage(Types.LeagueFriendInformations[] candidates)
        {
            this.candidates = candidates;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)candidates.Length);
            foreach (var entry in candidates)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            candidates = new Types.LeagueFriendInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 candidates[i] = new Types.LeagueFriendInformations();
                 candidates[i].Deserialize(reader);
            }
        }
        
    }
    
}