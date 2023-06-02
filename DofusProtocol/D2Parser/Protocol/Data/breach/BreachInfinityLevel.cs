

// Generated on 06/02/2023 19:01:29
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