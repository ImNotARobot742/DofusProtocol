

// Generated on 06/02/2023 19:01:29
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Challenges")]
    public class Challenge : IDataObject
    {
        public const String MODULE = "Challenges";
        public int id;
        public uint nameId;
        public uint descriptionId;
        public List<uint> incompatibleChallenges;
        public int categoryId;
        public int iconId;
        public String activationCriterion;
        public String completionCriterion;
        public uint targetMonsterId;
    }
}