

// Generated on 02/01/2023 12:54:52
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SkillNames")]
    public class SkillName : IDataObject
    {
        public const String MODULE = "SkillNames";
        public int id;
        public uint nameId;
    }
}