

// Generated on 06/13/2023 17:00:12
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Jobs")]
    public class Job : IDataObject
    {
        public const String MODULE = "Jobs";
        public int id;
        public uint nameId;
        public int iconId;
        public Boolean hasLegendaryCraft;
    }
}