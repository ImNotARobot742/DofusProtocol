

// Generated on 05/18/2023 15:10:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayArenaRegistrationWarningMessage : NetworkMessage
    {
        public const uint Id = 3082;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int battleMode;
        
        public GameRolePlayArenaRegistrationWarningMessage()
        {
        }
        
        public GameRolePlayArenaRegistrationWarningMessage(int battleMode)
        {
            this.battleMode = battleMode;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(battleMode);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            battleMode = reader.ReadInt();
        }
        
    }
    
}