using System;
using System.Collections.Generic;
using System.Text;

namespace GemFallAlphaLib
{
    public enum StatType { Attack, Defense, Magic, Resistance, Luck, Mana, Health }

    public struct UnitStat
    {
        public int Attack;
        public int Defense;
        public int Magic;
        public int Resistance;
        public int Luck;
        public int MaxMana;
        public int MaxHealth;


    }
}
