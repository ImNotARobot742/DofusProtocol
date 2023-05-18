

// Generated on 05/18/2023 15:11:07
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SpeakingItemsText")]
    public class SpeakingItemText : IDataObject
    {
        public const String MODULE = "SpeakingItemsText";
        public int textId;
        public double textProba;
        public uint textStringId;
        public int textLevel;
        public int textSound;
        public String textRestriction;
    }
}