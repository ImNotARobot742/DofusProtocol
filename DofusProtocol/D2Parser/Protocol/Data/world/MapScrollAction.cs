

// Generated on 06/13/2023 17:00:14
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MapScrollActions")]
    public class MapScrollAction : IDataObject
    {
        public const String MODULE = "MapScrollActions";
        public double id;
        public Boolean rightExists;
        public Boolean bottomExists;
        public Boolean leftExists;
        public Boolean topExists;
        public double rightMapId;
        public double bottomMapId;
        public double leftMapId;
        public double topMapId;
    }
}