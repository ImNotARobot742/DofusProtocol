

// Generated on 03/23/2022 09:51:50
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MountBehaviors")]
    public class MountBehavior : IDataObject
    {
        public const String MODULE = "MountBehaviors";
        public uint id;
        public uint nameId;
        public uint descriptionId;
    }
}