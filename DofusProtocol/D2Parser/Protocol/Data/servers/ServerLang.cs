

// Generated on 05/18/2023 15:11:08
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ServerLangs")]
    public class ServerLang : IDataObject
    {
        public const String MODULE = "ServerLangs";
        public int id;
        public uint nameId;
        public String langCode;
    }
}