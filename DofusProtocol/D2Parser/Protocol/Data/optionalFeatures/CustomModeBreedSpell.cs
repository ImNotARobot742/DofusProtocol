

// Generated on 06/13/2023 17:00:13
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