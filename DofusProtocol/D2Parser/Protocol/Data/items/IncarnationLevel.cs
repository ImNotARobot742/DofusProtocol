

// Generated on 05/18/2023 16:29:44
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