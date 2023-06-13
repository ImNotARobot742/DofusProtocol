

// Generated on 06/13/2023 17:00:12
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MonsterBonusCharacteristics")]
    public class MonsterBonusCharacteristics : IDataObject
    {
        public int lifePoints;
        public int strength;
        public int wisdom;
        public int chance;
        public int agility;
        public int intelligence;
        public int earthResistance;
        public int fireResistance;
        public int waterResistance;
        public int airResistance;
        public int neutralResistance;
        public int tackleEvade;
        public int tackleBlock;
        public int bonusEarthDamage;
        public int bonusFireDamage;
        public int bonusWaterDamage;
        public int bonusAirDamage;
        public int APRemoval;
    }
}