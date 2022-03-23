

// Generated on 03/23/2022 09:51:50
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