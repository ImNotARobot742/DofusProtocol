

// Generated on 06/13/2023 17:00:13
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SoundUiElement")]
    public class SoundUiElement : IDataObject
    {
        public String MODULE = "SoundUiElement";
        public uint id;
        public String name;
        public uint hookId;
        public String file;
        public uint volume;
    }
}