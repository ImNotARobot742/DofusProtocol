

// Generated on 06/13/2023 17:00:09
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AlterationCategories")]
    public class AlterationCategory : IDataObject
    {
        public const String MODULE = "AlterationCategories";
        public uint id;
        public uint nameId;
        public uint parentId;
    }
}