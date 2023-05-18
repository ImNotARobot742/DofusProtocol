

// Generated on 05/18/2023 15:11:08
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ServerTemporisSeasons")]
    public class ServerTemporisSeason : IDataObject
    {
        public const String MODULE = "ServerTemporisSeasons";
        public int uid;
        public uint seasonNumber;
        public String information;
        public double beginning;
        public double closure;
    }
}