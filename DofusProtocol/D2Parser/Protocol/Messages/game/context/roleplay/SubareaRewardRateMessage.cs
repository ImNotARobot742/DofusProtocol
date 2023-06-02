

// Generated on 06/02/2023 19:00:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SubareaRewardRateMessage : NetworkMessage
    {
        public const uint Id = 7713;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int subAreaRate;
        
        public SubareaRewardRateMessage()
        {
        }
        
        public SubareaRewardRateMessage(int subAreaRate)
        {
            this.subAreaRate = subAreaRate;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)subAreaRate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            subAreaRate = reader.ReadVarShort();
        }
        
    }
    
}