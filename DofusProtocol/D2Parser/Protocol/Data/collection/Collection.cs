

// Generated on 06/13/2023 17:00:10
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Collections")]
    public class Collection : IDataObject
    {
        public const String MODULE = "Collections";
        public int typeId;
        public int name;
        public String criterion;
        public List<Collectable> collectables;
    }
}