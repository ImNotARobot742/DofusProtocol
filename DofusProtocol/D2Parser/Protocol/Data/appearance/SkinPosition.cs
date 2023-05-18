

// Generated on 05/18/2023 16:29:43
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SkinPositions")]
    public class SkinPosition : IDataObject
    {
        private const String MODULE = "SkinPositions";
        public uint id;
        public List<TransformData> transformation;
        public List<String> clip;
        public List<uint> skin;
    }
}