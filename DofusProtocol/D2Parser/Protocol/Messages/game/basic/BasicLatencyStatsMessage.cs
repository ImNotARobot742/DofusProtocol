

// Generated on 02/01/2023 12:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BasicLatencyStatsMessage : NetworkMessage
    {
        public const uint Id = 7345;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public ushort latency;
        public uint sampleCount;
        public uint max;
        
        public BasicLatencyStatsMessage()
        {
        }
        
        public BasicLatencyStatsMessage(ushort latency, uint sampleCount, uint max)
        {
            this.latency = latency;
            this.sampleCount = sampleCount;
            this.max = max;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(latency);
            writer.WriteVarShort((short)sampleCount);
            writer.WriteVarShort((short)max);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            latency = reader.ReadUShort();
            sampleCount = reader.ReadVarUShort();
            max = reader.ReadVarUShort();
        }
        
    }
    
}