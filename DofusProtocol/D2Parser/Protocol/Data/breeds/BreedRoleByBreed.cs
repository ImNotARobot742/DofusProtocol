

// Generated on 05/18/2023 16:29:43
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("BreedRoleByBreeds")]
    public class BreedRoleByBreed : IDataObject
    {
        public const String MODULE = "BreedRoleByBreeds";
        public int breedId;
        public int roleId;
        public uint descriptionId;
        public int value;
        public int order;
    }
}