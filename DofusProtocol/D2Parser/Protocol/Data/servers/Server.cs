

// Generated on 06/13/2023 17:00:13
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Servers")]
    public class Server : IDataObject
    {
        public const String MODULE = "Servers";
        public int id;
        public uint nameId;
        public uint commentId;
        public double openingDate;
        public String language;
        public int populationId;
        public uint gameTypeId;
        public int communityId;
        public List<String> restrictedToLanguages;
        public Boolean monoAccount;
    }
}