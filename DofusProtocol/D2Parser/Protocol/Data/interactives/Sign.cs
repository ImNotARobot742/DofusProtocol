

// Generated on 03/23/2022 09:51:48
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Signs")]
    public class Sign : IDataObject
    {
        public const String MODULE = "Signs";
        public int id;
        public String @params;
        public int skillId;
        public uint textKey;
    }
}