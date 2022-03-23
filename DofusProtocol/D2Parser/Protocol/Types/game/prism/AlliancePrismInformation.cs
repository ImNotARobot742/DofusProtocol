

// Generated on 03/23/2022 09:51:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AlliancePrismInformation : PrismInformation
    {
        public const short Id = 766;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.AllianceInformations alliance;
        
        public AlliancePrismInformation()
        {
        }
        
        public AlliancePrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount, Types.AllianceInformations alliance)
         : base(typeId, state, nextVulnerabilityDate, placementDate, rewardTokenCount)
        {
            this.alliance = alliance;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            alliance.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            alliance = new Types.AllianceInformations();
            alliance.Deserialize(reader);
        }
        
    }
    
}