

// Generated on 03/23/2022 09:51:51
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SoundBones")]
    public class SoundBones : IDataObject
    {
        public String MODULE = "SoundBones";
        public uint id;
        public List<String> keys;
        public List<List<SoundAnimation>> values;
    }
}