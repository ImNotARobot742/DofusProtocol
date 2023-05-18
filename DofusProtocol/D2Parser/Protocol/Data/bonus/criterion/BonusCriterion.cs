

// Generated on 05/18/2023 15:11:04
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