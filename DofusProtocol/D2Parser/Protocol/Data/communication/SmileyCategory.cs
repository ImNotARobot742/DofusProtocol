

// Generated on 02/01/2023 12:54:51
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