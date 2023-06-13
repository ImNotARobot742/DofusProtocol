

// Generated on 06/13/2023 17:00:12
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Months")]
    public class Month : IDataObject
    {
        public const String MODULE = "Months";
        public int id;
        public uint nameId;
    }
}