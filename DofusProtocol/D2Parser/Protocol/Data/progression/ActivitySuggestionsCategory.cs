

// Generated on 06/02/2023 19:01:31
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