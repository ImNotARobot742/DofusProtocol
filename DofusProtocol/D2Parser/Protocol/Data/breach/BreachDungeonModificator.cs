

// Generated on 05/18/2023 15:11:04
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("BreachDungeonModificators")]
    public class BreachDungeonModificator : IDataObject
    {
        public const String MODULE = "BreachDungeonModificators";
        public uint id;
        public uint modificatorId;
        public String criterion;
        public double additionalRewardPercent;
        public double score;
        public Boolean isPositiveForPlayers;
        public String tooltipBaseline;
    }
}