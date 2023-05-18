

// Generated on 05/18/2023 16:28:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightTurnResumeMessage : GameFightTurnStartMessage
    {
        public const uint Id = 8146;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint remainingTime;
        
        public GameFightTurnResumeMessage()
        {
        }
        
        public GameFightTurnResumeMessage(double id, uint waitTime, uint remainingTime)
         : base(id, waitTime)
        {
            this.remainingTime = remainingTime;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)remainingTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            remainingTime = reader.ReadVarUInt();
        }
        
    }
    
}