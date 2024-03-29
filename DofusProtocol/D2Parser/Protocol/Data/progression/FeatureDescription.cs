

// Generated on 06/13/2023 17:00:13
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("FeatureDescriptions")]
    public class FeatureDescription : IDataObject
    {
        public const String MODULE = "FeatureDescriptions";
        public int id;
        public uint nameId;
        public uint descriptionId;
        public uint priority;
        public uint parentId;
        public List<int> children;
        public String criterion;
    }
}