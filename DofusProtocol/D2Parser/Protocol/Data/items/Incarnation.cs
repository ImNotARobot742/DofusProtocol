

// Generated on 02/01/2023 12:54:52
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