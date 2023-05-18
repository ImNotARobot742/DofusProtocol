

// Generated on 05/18/2023 15:10:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BasicStatMessage : NetworkMessage
    {
        public const uint Id = 4091;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double timeSpent;
        public uint statId;
        
        public BasicStatMessage()
        {
        }
        
        public BasicStatMessage(double timeSpent, uint statId)
        {
            this.timeSpent = timeSpent;
            this.statId = statId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(timeSpent);
            writer.WriteVarShort((short)statId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            timeSpent = reader.ReadDouble();
            statId = reader.ReadVarUShort();
        }
        
    }
    
}