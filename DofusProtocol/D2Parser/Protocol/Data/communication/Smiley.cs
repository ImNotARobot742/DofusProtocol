

// Generated on 03/23/2022 09:51:48
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Smileys")]
    public class Smiley : IDataObject
    {
        public const String MODULE = "Smileys";
        public uint id;
        public uint order;
        public String gfxId;
        public Boolean forPlayers;
        public List<String> triggers;
        public uint referenceId;
        public uint categoryId;
    }
}