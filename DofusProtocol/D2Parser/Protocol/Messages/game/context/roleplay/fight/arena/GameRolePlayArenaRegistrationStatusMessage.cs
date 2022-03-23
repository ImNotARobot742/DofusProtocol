

// Generated on 03/23/2022 09:50:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayArenaRegistrationStatusMessage : NetworkMessage
    {
        public const uint Id = 6165;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool registered;
        public sbyte step;
        public int battleMode;
        
        public GameRolePlayArenaRegistrationStatusMessage()
        {
        }
        
        public GameRolePlayArenaRegistrationStatusMessage(bool registered, sbyte step, int battleMode)
        {
            this.registered = registered;
            this.step = step;
            this.battleMode = battleMode;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(registered);
            writer.WriteSbyte(step);
            writer.WriteInt(battleMode);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            registered = reader.ReadBoolean();
            step = reader.ReadSbyte();
            battleMode = reader.ReadInt();
        }
        
    }
    
}