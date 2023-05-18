

// Generated on 05/18/2023 16:29:45
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Skills")]
    public class Skill : IDataObject
    {
        public const String MODULE = "Skills";
        public int id;
        public uint nameId;
        public int parentJobId;
        public Boolean isForgemagus;
        public List<int> modifiableItemTypeIds;
        public int gatheredRessourceItem;
        public List<int> craftableItemIds;
        public int interactiveId;
        public int range;
        public Boolean useRangeInClient;
        public String useAnimation;
        public int cursor;
        public int elementActionId;
        public Boolean availableInHouse;
        public uint levelMin;
        public Boolean clientDisplay;
    }
}