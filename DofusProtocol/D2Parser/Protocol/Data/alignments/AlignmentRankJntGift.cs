

// Generated on 05/18/2023 15:11:04
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AlignmentRankJntGift")]
    public class AlignmentRankJntGift : IDataObject
    {
        public const String MODULE = "AlignmentRankJntGift";
        public int id;
        public List<int> gifts;
        public List<int> levels;
    }
}