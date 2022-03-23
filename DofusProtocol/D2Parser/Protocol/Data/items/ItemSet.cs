

// Generated on 03/23/2022 09:51:49
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ItemSets")]
    public class ItemSet : IDataObject
    {
        public const String MODULE = "ItemSets";
        public uint id;
        public List<uint> items;
        public uint nameId;
        public List<List<EffectInstance>> effects;
        public Boolean bonusIsSecret;
    }
}