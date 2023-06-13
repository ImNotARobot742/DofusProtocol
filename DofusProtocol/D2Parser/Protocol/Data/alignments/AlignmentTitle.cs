

// Generated on 06/13/2023 17:00:09
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AlignmentTitles")]
    public class AlignmentTitle : IDataObject
    {
        public const String MODULE = "AlignmentTitles";
        public int sideId;
        public List<int> namesId;
        public List<int> shortsId;
    }
}