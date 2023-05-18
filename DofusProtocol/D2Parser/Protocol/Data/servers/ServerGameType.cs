

// Generated on 05/18/2023 15:11:08
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("ServerGameTypes")]
    public class ServerGameType : IDataObject
    {
        public const String MODULE = "ServerGameTypes";
        public int id;
        public Boolean selectableByPlayer;
        public uint nameId;
        public uint rulesId;
        public uint descriptionId;
    }
}