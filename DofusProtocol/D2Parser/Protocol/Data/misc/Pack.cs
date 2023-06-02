

// Generated on 06/02/2023 19:01:31
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