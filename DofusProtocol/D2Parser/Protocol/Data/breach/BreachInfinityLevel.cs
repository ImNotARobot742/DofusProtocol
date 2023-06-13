

// Generated on 06/13/2023 17:00:10
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("BreachInfinityLevels")]
    public class BreachInfinityLevel : IDataObject
    {
        public const String MODULE = "BreachInfinityLevels";
        public uint id;
        public uint nameId;
        public uint level;
    }
}