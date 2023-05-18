

// Generated on 05/18/2023 16:29:45
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("TaxCollectorNames")]
    public class TaxCollectorName : IDataObject
    {
        public const String MODULE = "TaxCollectorNames";
        public int id;
        public uint nameId;
    }
}