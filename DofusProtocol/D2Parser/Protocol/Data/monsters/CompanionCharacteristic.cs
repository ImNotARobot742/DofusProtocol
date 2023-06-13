

// Generated on 06/13/2023 17:00:12
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("CompanionCharacteristics")]
    public class CompanionCharacteristic : IDataObject
    {
        public const String MODULE = "CompanionCharacteristics";
        public int id;
        public int caracId;
        public int companionId;
        public int order;
        public List<List<double>> statPerLevelRange;
    }
}