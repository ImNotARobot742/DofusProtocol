

// Generated on 05/18/2023 15:10:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayArenaFightAnswerMessage : NetworkMessage
    {
        public const uint Id = 2915;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint fightId;
        public bool accept;
        
        public GameRolePlayArenaFightAnswerMessage()
        {
        }
        
        public GameRolePlayArenaFightAnswerMessage(uint fightId, bool accept)
        {
            this.fightId = fightId;
            this.accept = accept;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)fightId);
            writer.WriteBoolean(accept);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadVarUShort();
            accept = reader.ReadBoolean();
        }
        
    }
    
}