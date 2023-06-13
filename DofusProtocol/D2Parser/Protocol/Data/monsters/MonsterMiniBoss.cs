

// Generated on 06/13/2023 17:00:12
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MonsterMiniBoss")]
    public class MonsterMiniBoss : IDataObject
    {
        public const String MODULE = "MonsterMiniBoss";
        public int id;
        public int monsterReplacingId;
    }
}