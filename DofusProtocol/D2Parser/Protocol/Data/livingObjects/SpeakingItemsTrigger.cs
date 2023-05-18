

// Generated on 05/18/2023 16:29:45
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SpeakingItemsTriggers")]
    public class SpeakingItemsTrigger : IDataObject
    {
        public const String MODULE = "SpeakingItemsTriggers";
        public int triggersId;
        public List<int> textIds;
        public List<int> states;
    }
}