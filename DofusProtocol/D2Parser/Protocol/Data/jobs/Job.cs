

// Generated on 03/23/2022 09:51:50
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