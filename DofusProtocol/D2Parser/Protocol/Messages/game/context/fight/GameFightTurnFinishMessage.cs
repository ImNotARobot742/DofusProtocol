

// Generated on 05/18/2023 16:28:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightTurnFinishMessage : NetworkMessage
    {
        public const uint Id = 3533;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool isAfk;
        
        public GameFightTurnFinishMessage()
        {
        }
        
        public GameFightTurnFinishMessage(bool isAfk)
        {
            this.isAfk = isAfk;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(isAfk);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            isAfk = reader.ReadBoolean();
        }
        
    }
    
}