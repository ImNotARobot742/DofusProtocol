

// Generated on 05/18/2023 15:11:05
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