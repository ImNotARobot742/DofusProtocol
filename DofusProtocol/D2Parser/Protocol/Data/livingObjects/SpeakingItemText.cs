

// Generated on 02/01/2023 12:54:53
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