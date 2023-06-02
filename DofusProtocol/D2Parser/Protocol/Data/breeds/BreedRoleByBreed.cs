

// Generated on 06/02/2023 19:01:29
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