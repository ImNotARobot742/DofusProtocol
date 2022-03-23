

// Generated on 03/23/2022 09:51:51
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SoundUi")]
    public class SoundUi : IDataObject
    {
        public String MODULE = "SoundUi";
        public uint id;
        public String uiName;
        public String openFile;
        public String closeFile;
        public List<SoundUiElement> subElements;
    }
}