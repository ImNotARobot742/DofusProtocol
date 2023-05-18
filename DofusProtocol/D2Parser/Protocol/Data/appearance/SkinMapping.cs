

// Generated on 05/18/2023 16:29:43
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SkinMappings")]
    public class SkinMapping : IDataObject
    {
        public const String MODULE = "SkinMappings";
        public int id;
        public int lowDefId;
    }
}