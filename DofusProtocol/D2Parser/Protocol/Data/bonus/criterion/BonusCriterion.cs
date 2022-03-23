

// Generated on 03/23/2022 09:51:47
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