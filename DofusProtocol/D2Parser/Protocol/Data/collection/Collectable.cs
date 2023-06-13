

// Generated on 06/13/2023 17:00:10
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