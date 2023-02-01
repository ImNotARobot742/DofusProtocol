

// Generated on 02/01/2023 12:54:51
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