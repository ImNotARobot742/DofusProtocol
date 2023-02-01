

// Generated on 02/01/2023 12:54:52
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("IncarnationLevels")]
    public class IncarnationLevel : IDataObject
    {
        public const String MODULE = "IncarnationLevels";
        public int id;
        public int incarnationId;
        public int level;
        public uint requiredXp;
    }
}