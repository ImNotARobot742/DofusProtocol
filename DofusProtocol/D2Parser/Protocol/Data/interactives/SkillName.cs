

// Generated on 06/02/2023 19:01:29
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