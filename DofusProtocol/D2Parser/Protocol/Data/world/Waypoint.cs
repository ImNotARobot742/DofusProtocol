

// Generated on 06/02/2023 19:01:32
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Waypoints")]
    public class Waypoint : IDataObject
    {
        public const String MODULE = "Waypoints";
        public uint id;
        public double mapId;
        public uint subAreaId;
        public Boolean activated;
    }
}