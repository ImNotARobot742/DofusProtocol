

// Generated on 06/02/2023 19:01:28
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