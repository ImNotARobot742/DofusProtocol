

// Generated on 05/18/2023 15:11:07
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