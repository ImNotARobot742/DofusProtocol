

// Generated on 05/18/2023 16:29:45
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("CustomModeBreedSpells")]
    public class CustomModeBreedSpell : IDataObject
    {
        public const String MODULE = "CustomModeBreedSpells";
        public int id;
        public int pairId;
        public int breedId;
        public Boolean isInitialSpell;
        public Boolean isHidden;
    }
}