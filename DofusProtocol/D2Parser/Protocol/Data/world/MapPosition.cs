

// Generated on 03/23/2022 09:51:51
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