

// Generated on 06/02/2023 19:01:28
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