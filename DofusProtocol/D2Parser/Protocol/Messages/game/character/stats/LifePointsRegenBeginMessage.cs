

// Generated on 06/13/2023 16:59:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LifePointsRegenBeginMessage : NetworkMessage
    {
        public const uint Id = 2914;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public byte regenRate;
        
        public LifePointsRegenBeginMessage()
        {
        }
        
        public LifePointsRegenBeginMessage(byte regenRate)
        {
            this.regenRate = regenRate;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(regenRate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            regenRate = reader.ReadByte();
        }
        
    }
    
}