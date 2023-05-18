

// Generated on 05/18/2023 16:29:42
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("PlaylistSounds")]
    public class PlaylistSound : IDataObject
    {
        public const String MODULE = "PlaylistSounds";
        public String id;
        public int volume;
        public int channel = 0;
        public int soundOrder;
    }
}