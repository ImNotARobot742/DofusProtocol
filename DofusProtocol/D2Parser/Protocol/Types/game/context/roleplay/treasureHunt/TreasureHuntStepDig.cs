

// Generated on 03/23/2022 09:51:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TreasureHuntStepDig : TreasureHuntStep
    {
        public const short Id = 3592;
        public override short TypeId
        {
            get { return Id; }
        }
        
        
        public TreasureHuntStepDig()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}