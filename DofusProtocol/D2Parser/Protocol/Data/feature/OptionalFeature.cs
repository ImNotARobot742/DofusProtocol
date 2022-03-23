

// Generated on 03/23/2022 09:51:48
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