

// Generated on 03/23/2022 09:51:48
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("EmblemSymbols")]
    public class EmblemSymbol : IDataObject
    {
        public const String MODULE = "EmblemSymbols";
        public int id;
        public int iconId;
        public int skinId;
        public int order;
        public int categoryId;
        public Boolean colorizable;
    }
}