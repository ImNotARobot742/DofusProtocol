

// Generated on 03/23/2022 09:50:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightRemoveTeamMemberMessage : NetworkMessage
    {
        public const uint Id = 6771;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint fightId;
        public sbyte teamId;
        public double charId;
        
        public GameFightRemoveTeamMemberMessage()
        {
        }
        
        public GameFightRemoveTeamMemberMessage(uint fightId, sbyte teamId, double charId)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.charId = charId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)fightId);
            writer.WriteSbyte(teamId);
            writer.WriteDouble(charId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadVarUShort();
            teamId = reader.ReadSbyte();
            charId = reader.ReadDouble();
        }
        
    }
    
}