

// Generated on 06/13/2023 17:00:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AnomalySubareaInformation
    {
        public const short Id = 6183;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        public int rewardRate;
        public bool hasAnomaly;
        public double anomalyClosingTime;
        
        public AnomalySubareaInformation()
        {
        }
        
        public AnomalySubareaInformation(uint subAreaId, int rewardRate, bool hasAnomaly, double anomalyClosingTime)
        {
            this.subAreaId = subAreaId;
            this.rewardRate = rewardRate;
            this.hasAnomaly = hasAnomaly;
            this.anomalyClosingTime = anomalyClosingTime;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)subAreaId);
            writer.WriteVarShort((short)rewardRate);
            writer.WriteBoolean(hasAnomaly);
            writer.WriteVarLong(anomalyClosingTime);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            subAreaId = reader.ReadVarUShort();
            rewardRate = reader.ReadVarShort();
            hasAnomaly = reader.ReadBoolean();
            anomalyClosingTime = reader.ReadVarULong();
        }
        
    }
    
}