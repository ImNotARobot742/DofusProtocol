

// Generated on 05/18/2023 15:11:08
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("FinishMoves")]
    public class FinishMove : IDataObject
    {
        public const String MODULE = "FinishMoves";
        public int id;
        public int duration;
        public Boolean free;
        public uint nameId;
        public int category;
        public int spellLevel;
    }
}