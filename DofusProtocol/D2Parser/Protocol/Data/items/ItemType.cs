

// Generated on 06/13/2023 17:00:11
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ItemTypes")]
    public class ItemType : IDataObject
    {
        public const String MODULE = "ItemTypes";
        public int id;
        public uint nameId;
        public uint superTypeId;
        public uint categoryId;
        public Boolean isInEncyclopedia;
        public Boolean plural;
        public uint gender;
        public String rawZone;
        public Boolean mimickable;
        public int craftXpRatio;
        public int evolutiveTypeId;
    }
}