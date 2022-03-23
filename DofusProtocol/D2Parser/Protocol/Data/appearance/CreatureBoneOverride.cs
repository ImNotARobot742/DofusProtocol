

// Generated on 03/23/2022 09:51:47
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