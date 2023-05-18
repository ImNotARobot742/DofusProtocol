

// Generated on 05/18/2023 16:29:44
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Incarnation")]
    public class Incarnation : IDataObject
    {
        public const String MODULE = "Incarnation";
        public uint id;
        public uint maleBoneId;
        public uint femaleBoneId;
        public String lookMale;
        public String lookFemale;
    }
}