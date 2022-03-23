

// Generated on 03/23/2022 09:51:47
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Ornaments")]
    public class Ornament : IDataObject
    {
        public const String MODULE = "Ornaments";
        public int id;
        public uint nameId;
        public Boolean visible;
        public int assetId;
        public int iconId;
        public int order;
    }
}