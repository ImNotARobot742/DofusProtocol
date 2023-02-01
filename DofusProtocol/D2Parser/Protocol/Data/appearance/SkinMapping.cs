

// Generated on 02/01/2023 12:54:50
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