

// Generated on 03/23/2022 09:51:48
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("BreedRoles")]
    public class BreedRole : IDataObject
    {
        public const String MODULE = "BreedRoles";
        public int id;
        public uint nameId;
        public uint descriptionId;
        public int assetId;
        public int color;
    }
}