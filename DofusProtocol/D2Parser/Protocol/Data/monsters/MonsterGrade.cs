

// Generated on 03/23/2022 09:51:50
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("MonsterGrade")]
    public class MonsterGrade : IDataObject
    {
        public uint grade;
        public int monsterId;
        public uint level;
        public int vitality;
        public int paDodge;
        public int pmDodge;
        public int wisdom;
        public int earthResistance;
        public int airResistance;
        public int fireResistance;
        public int waterResistance;
        public int neutralResistance;
        public int gradeXp;
        public int lifePoints;
        public int actionPoints;
        public int movementPoints;
        public int damageReflect;
        public uint hiddenLevel;
        public int strength;
        public int intelligence;
        public int chance;
        public int agility;
        public int bonusRange;
        public int startingSpellId;
        public MonsterBonusCharacteristics bonusCharacteristics = null;
    }
}