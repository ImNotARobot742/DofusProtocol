

// Generated on 02/01/2023 12:54:51
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("CharacteristicCategories")]
    public class CharacteristicCategory : IDataObject
    {
        public const String MODULE = "CharacteristicCategories";
        public int id;
        public uint nameId;
        public int order;
        public List<uint> characteristicIds;
    }
}