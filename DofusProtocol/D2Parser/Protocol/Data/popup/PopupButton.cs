

// Generated on 05/18/2023 16:29:45
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("PopupButton")]
    public class PopupButton : IDataObject
    {
        public int id;
        public uint popupId;
        public uint type;
        public uint textId;
        public uint actionType;
        public String actionValue;
    }
}