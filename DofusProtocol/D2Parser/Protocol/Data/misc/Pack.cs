

// Generated on 02/01/2023 12:54:53
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