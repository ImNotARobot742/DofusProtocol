

// Generated on 03/23/2022 09:51:48
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Characteristics")]
    public class Characteristic : IDataObject
    {
        public const String MODULE = "Characteristics";
        public int id;
        public String keyword;
        public uint nameId;
        public String asset;
        public int categoryId;
        public Boolean visible;
        public int order;
        public int scaleFormulaId;
        public Boolean upgradable;
    }
}