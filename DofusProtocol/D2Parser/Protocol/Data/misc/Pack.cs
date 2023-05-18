

// Generated on 05/18/2023 16:29:45
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Pack")]
    public class Pack : IDataObject
    {
        public const String MODULE = "Pack";
        public int id;
        public String name;
        public Boolean hasSubAreas;
    }
}