

// Generated on 06/13/2023 17:00:09
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("AlmanaxCalendars")]
    public class AlmanaxCalendar : IDataObject
    {
        public const String MODULE = "AlmanaxCalendars";
        public int id;
        public uint nameId;
        public uint descId;
        public int npcId;
        public List<int> bonusesIds;
    }
}