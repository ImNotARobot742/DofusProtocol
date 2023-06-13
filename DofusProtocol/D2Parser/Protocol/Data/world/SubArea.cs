

// Generated on 06/13/2023 17:00:14
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("SubAreas")]
    public class SubArea : IDataObject
    {
        public const String MODULE = "SubAreas";
        public int id;
        public uint nameId;
        public int areaId;
        public List<List<int>> playlists;
        public List<double> mapIds;
        public Rectangle bounds;
        public List<int> shape;
        public int worldmapId;
        public List<uint> customWorldMap;
        public int packId;
        public uint level;
        public Boolean isConquestVillage;
        public Boolean basicAccountAllowed;
        public Boolean displayOnWorldMap;
        public Boolean mountAutoTripAllowed;
        public Boolean psiAllowed;
        public List<uint> monsters;
        public Boolean capturable;
        public List<List<double>> quests;
        public List<List<double>> npcs;
        public List<int> harvestables;
        public int associatedZaapMapId;
    }
}