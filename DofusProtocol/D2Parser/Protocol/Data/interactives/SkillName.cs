

// Generated on 03/23/2022 09:51:48
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