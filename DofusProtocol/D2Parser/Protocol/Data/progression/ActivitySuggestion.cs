

// Generated on 03/23/2022 09:51:50
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ActivitySuggestions")]
    public class ActivitySuggestion : IDataObject
    {
        public const String MODULE = "ActivitySuggestions";
        public int id;
        public uint nameId;
        public uint descriptionId;
        public int categoryId;
        public uint level;
        public double mapId;
        public Boolean isLarge;
        public double startDate;
        public double endDate;
        public String icon;
    }
}