

// Generated on 06/02/2023 19:01:28
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("TitleCategories")]
    public class TitleCategory : IDataObject
    {
        public const String MODULE = "TitleCategories";
        public int id;
        public uint nameId;
    }
}