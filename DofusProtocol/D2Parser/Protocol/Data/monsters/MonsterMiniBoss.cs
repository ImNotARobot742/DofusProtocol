

// Generated on 05/18/2023 15:11:07
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