

// Generated on 02/01/2023 12:54:52
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Interactives")]
    public class Interactive : IDataObject
    {
        public const String MODULE = "Interactives";
        public int id;
        public uint nameId;
        public int actionId;
        public Boolean displayTooltip;
    }
}