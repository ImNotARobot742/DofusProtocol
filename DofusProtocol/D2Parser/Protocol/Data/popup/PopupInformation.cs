

// Generated on 05/18/2023 16:29:45
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("PopupInformations")]
    public class PopupInformation : IDataObject
    {
        public const String MODULE = "PopupInformations";
        public int id;
        public uint parentId;
        public uint titleId;
        public uint descriptionId;
        public String illuName;
        public List<PopupButton> buttons;
        public String criterion;
        public uint cacheType;
        public Boolean autoTrigger;
    }
}