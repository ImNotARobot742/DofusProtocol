

// Generated on 02/01/2023 12:54:54
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