

// Generated on 06/02/2023 19:01:29
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("OptionalFeatures")]
    public class OptionalFeature : IDataObject
    {
        public const String MODULE = "OptionalFeatures";
        public int id;
        public String keyword;
        public Boolean isClient;
        public Boolean isServer;
        public Boolean isActivationOnLaunch = false;
        public Boolean isActivationOnServerConnection = false;
        public String activationCriterions = null;
    }
}