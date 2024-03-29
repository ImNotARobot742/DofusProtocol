

// Generated on 06/13/2023 16:59:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightNewRoundMessage : NetworkMessage
    {
        public const uint Id = 407;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint roundNumber;
        
        public GameFightNewRoundMessage()
        {
        }
        
        public GameFightNewRoundMessage(uint roundNumber)
        {
            this.roundNumber = roundNumber;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)roundNumber);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            roundNumber = reader.ReadVarUInt();
        }
        
    }
    
}