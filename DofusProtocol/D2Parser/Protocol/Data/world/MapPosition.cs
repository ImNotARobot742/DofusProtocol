

// Generated on 05/18/2023 16:29:46
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MapPositions")]
    public class MapPosition : IDataObject
    {
        public const String MODULE = "MapPositions";
        public double id;
        public int posX;
        public int posY;
        public Boolean outdoor;
        public int capabilities;
        public int nameId;
        public List<List<int>> playlists;
        public int subAreaId;
        public int worldMap;
        public Boolean hasPriorityOnWorldmap;
        public Boolean allowPrism;
        public Boolean isTransition;
        public Boolean mapHasTemplate;
        public uint tacticalModeTemplateId;
        public Boolean hasPublicPaddock;
    }
}