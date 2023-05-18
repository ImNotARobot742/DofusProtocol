

// Generated on 05/18/2023 16:29:43
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SmileyCategories")]
    public class SmileyCategory : IDataObject
    {
        public const String MODULE = "SmileyCategories";
        public int id;
        public uint order;
        public String gfxId;
        public Boolean isFake;
    }
}