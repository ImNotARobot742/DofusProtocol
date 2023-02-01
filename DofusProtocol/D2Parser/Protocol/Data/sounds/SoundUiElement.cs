

// Generated on 02/01/2023 12:54:54
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