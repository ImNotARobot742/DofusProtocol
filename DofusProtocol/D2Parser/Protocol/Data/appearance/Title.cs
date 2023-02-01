

// Generated on 02/01/2023 12:54:50
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