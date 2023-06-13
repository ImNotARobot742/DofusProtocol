

// Generated on 06/13/2023 17:00:10
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("BonusesCriterions")]
    public class BonusCriterion : IDataObject
    {
        public const String MODULE = "BonusesCriterions";
        public int id;
        public uint type;
        public int value;
    }
}