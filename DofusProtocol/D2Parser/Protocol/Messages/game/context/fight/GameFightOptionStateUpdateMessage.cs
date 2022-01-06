

// Generated on 01/01/2022 14:39:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightOptionStateUpdateMessage : NetworkMessage
    {
        public const uint Id = 4608;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint fightId;
        public sbyte teamId;
        public sbyte option;
        public bool state;
        
        public GameFightOptionStateUpdateMessage()
        {
        }
        
        public GameFightOptionStateUpdateMessage(uint fightId, sbyte teamId, sbyte option, bool state)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.option = option;
            this.state = state;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)fightId);
            writer.WriteSbyte(teamId);
            writer.WriteSbyte(option);
            writer.WriteBoolean(state);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadVarUShort();
            teamId = reader.ReadSbyte();
            option = reader.ReadSbyte();
            state = reader.ReadBoolean();
        }
        
    }
    
}