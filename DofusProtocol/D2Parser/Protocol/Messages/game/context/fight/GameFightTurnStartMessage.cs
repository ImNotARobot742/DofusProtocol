

// Generated on 05/18/2023 16:28:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightTurnStartMessage : NetworkMessage
    {
        public const uint Id = 9781;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double id;
        public uint waitTime;
        
        public GameFightTurnStartMessage()
        {
        }
        
        public GameFightTurnStartMessage(double id, uint waitTime)
        {
            this.id = id;
            this.waitTime = waitTime;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(id);
            writer.WriteVarInt((int)waitTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            id = reader.ReadDouble();
            waitTime = reader.ReadVarUInt();
        }
        
    }
    
}