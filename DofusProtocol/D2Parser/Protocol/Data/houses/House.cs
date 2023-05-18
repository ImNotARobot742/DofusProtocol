

// Generated on 05/18/2023 15:11:05
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Houses")]
    public class House : IDataObject
    {
        public const String MODULE = "Houses";
        public int typeId;
        public uint defaultPrice;
        public int nameId;
        public int descriptionId;
        public int gfxId;
    }
}