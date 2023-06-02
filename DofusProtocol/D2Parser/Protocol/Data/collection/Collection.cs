

// Generated on 06/02/2023 19:01:29
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