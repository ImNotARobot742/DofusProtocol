

// Generated on 05/18/2023 15:11:05
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("HavenbagFurnitures")]
    public class HavenbagFurniture : IDataObject
    {
        public const String MODULE = "HavenbagFurnitures";
        public int typeId;
        public int themeId;
        public int elementId;
        public int color;
        public int skillId;
        public int layerId;
        public Boolean blocksMovement;
        public Boolean isStackable;
        public uint cellsWidth;
        public uint cellsHeight;
        public uint order;
    }
}