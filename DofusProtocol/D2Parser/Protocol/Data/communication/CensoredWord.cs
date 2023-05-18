

// Generated on 05/18/2023 15:11:05
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("CensoredWords")]
    public class CensoredWord : IDataObject
    {
        public const String MODULE = "CensoredWords";
        public uint id;
        public uint listId;
        public String language;
        public String word;
        public Boolean deepLooking;
    }
}