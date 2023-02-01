

// Generated on 02/01/2023 12:54:54
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