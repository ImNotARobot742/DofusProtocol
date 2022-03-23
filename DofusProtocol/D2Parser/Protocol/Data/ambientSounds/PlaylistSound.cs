

// Generated on 03/23/2022 09:51:47
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