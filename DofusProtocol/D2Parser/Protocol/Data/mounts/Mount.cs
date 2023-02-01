

// Generated on 02/01/2023 12:54:53
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Mounts")]
    public class Mount : IDataObject
    {
        public const String MODULE = "Mounts";
        public uint id;
        public uint familyId;
        public uint nameId;
        public String look;
        public uint certificateId;
        public List<EffectInstance> effects;
    }
}