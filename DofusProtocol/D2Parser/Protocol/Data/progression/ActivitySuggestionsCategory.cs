

// Generated on 02/01/2023 12:54:54
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ActivitySuggestionsCategories")]
    public class ActivitySuggestionsCategory : IDataObject
    {
        public const String MODULE = "ActivitySuggestionsCategories";
        public int id;
        public uint nameId;
        public uint parentId;
    }
}