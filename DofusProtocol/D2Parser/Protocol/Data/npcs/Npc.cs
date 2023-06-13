

// Generated on 06/13/2023 17:00:13
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Npcs")]
    public class Npc : IDataObject
    {
        public const String MODULE = "Npcs";
        public int id;
        public uint nameId;
        public List<List<int>> dialogMessages;
        public List<List<int>> dialogReplies;
        public List<uint> actions;
        public uint gender;
        public String look;
        public int tokenShop;
        public List<AnimFunNpcData> animFunList;
        public Boolean fastAnimsFun;
        public Boolean tooltipVisible;
    }
}