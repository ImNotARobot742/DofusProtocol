

// Generated on 03/23/2022 09:51:51
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SoundAnimations")]
    public class SoundAnimation : IDataObject
    {
        public String MODULE = "SoundAnimations";
        public uint id;
        public String name;
        public String label;
        public String filename;
        public int volume;
        public int rolloff;
        public int automationDuration;
        public int automationVolume;
        public int automationFadeIn;
        public int automationFadeOut;
        public Boolean noCutSilence;
        public uint startFrame;
    }
}