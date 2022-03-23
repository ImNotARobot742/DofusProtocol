

// Generated on 03/23/2022 09:51:50
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