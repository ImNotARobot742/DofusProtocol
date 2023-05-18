

// Generated on 05/18/2023 16:29:43
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Collectables")]
    public class Collectable : IDataObject
    {
        public const String MODULE = "Collectables";
        public int entityId;
        public int name;
        public int typeId;
        public int gfxId;
        public int order;
        public int rarity;
    }
}