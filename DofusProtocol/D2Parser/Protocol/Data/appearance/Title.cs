

// Generated on 03/23/2022 09:51:47
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Titles")]
    public class Title : IDataObject
    {
        public const String MODULE = "Titles";
        public int id;
        public uint nameMaleId;
        public uint nameFemaleId;
        public Boolean visible;
        public int categoryId;
    }
}