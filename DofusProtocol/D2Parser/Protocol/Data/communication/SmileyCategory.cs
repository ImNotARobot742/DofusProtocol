

// Generated on 06/13/2023 17:00:10
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