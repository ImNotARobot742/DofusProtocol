

// Generated on 02/01/2023 12:54:50
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