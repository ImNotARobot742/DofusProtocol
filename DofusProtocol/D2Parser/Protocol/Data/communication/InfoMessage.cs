

// Generated on 05/18/2023 15:11:05
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