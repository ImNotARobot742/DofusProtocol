

// Generated on 03/23/2022 09:51:50
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("QuestObjectives")]
    public class QuestObjective : IDataObject
    {
        public const String MODULE = "QuestObjectives";
        public uint id;
        public uint stepId;
        public uint typeId;
        public int dialogId;
        public QuestObjectiveParameters parameters;
        public Point coords;
        public double mapId;
        public QuestObjectiveType type;
    }
}