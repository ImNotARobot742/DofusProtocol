

// Generated on 06/13/2023 16:59:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightNewWaveMessage : NetworkMessage
    {
        public const uint Id = 8046;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte id;
        public sbyte teamId;
        public short nbTurnBeforeNextWave;
        
        public GameFightNewWaveMessage()
        {
        }
        
        public GameFightNewWaveMessage(sbyte id, sbyte teamId, short nbTurnBeforeNextWave)
        {
            this.id = id;
            this.teamId = teamId;
            this.nbTurnBeforeNextWave = nbTurnBeforeNextWave;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(id);
            writer.WriteSbyte(teamId);
            writer.WriteShort(nbTurnBeforeNextWave);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            id = reader.ReadSbyte();
            teamId = reader.ReadSbyte();
            nbTurnBeforeNextWave = reader.ReadShort();
        }
        
    }
    
}