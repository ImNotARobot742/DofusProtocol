

// Generated on 02/01/2023 12:54:55
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
        public Boolean showNameOnFingerpost;
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