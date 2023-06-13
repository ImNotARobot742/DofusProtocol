

// Generated on 06/13/2023 16:59:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayArenaRegisterMessage : NetworkMessage
    {
        public const uint Id = 6241;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int battleMode;
        
        public GameRolePlayArenaRegisterMessage()
        {
        }
        
        public GameRolePlayArenaRegisterMessage(int battleMode)
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