

// Generated on 06/13/2023 17:00:10
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("InfoMessages")]
    public class InfoMessage : IDataObject
    {
        public const String MODULE = "InfoMessages";
        public uint typeId;
        public uint messageId;
        public uint textId;
    }
}