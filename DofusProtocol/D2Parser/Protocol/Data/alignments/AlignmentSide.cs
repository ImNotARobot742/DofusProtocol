

// Generated on 06/02/2023 19:01:28
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AlignmentSides")]
    public class AlignmentSide : IDataObject
    {
        public const String MODULE = "AlignmentSides";
        public int id;
        public uint nameId;
    }
}