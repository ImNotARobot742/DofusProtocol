

// Generated on 03/23/2022 09:51:50
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("CharacterXPMappings")]
    public class CharacterXPMapping : IDataObject
    {
        public const String MODULE = "CharacterXPMappings";
        public int level;
        public double experiencePoints;
    }
}