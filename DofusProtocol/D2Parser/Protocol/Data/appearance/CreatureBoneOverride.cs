

// Generated on 05/18/2023 16:29:42
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("CreatureBonesOverrides")]
    public class CreatureBoneOverride : IDataObject
    {
        public const String MODULE = "CreatureBonesOverrides";
        public int boneId;
        public int creatureBoneId;
    }
}