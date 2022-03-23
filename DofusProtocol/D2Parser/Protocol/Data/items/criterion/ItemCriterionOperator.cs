

// Generated on 03/23/2022 09:51:49
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ItemCriterionOperator")]
    public class ItemCriterionOperator : IDataObject
    {
        public const String SUPERIOR = ">";
        public const String INFERIOR = "<";
        public const String EQUAL = "";
        public const String DIFFERENT = "!";
    }
}