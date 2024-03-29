

// Generated on 06/13/2023 17:00:09
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Alterations")]
    public class Alteration : IDataObject
    {
        public const String MODULE = "Alterations";
        public uint id;
        public uint nameId;
        public uint descriptionId;
        public uint categoryId;
        public int iconId;
        public Boolean isVisible;
        public String criteria;
        public Boolean isWebDisplay;
        public List<EffectInstance> possibleEffects = null;
    }
}