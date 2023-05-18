

// Generated on 05/18/2023 16:29:46
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ServerPopulations")]
    public class ServerPopulation : IDataObject
    {
        public const String MODULE = "ServerPopulations";
        public int id;
        public uint nameId;
        public int weight;
    }
}