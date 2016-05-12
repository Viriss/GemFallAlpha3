using System;
using System.Collections.Generic;
using System.Text;

namespace GemFallAlphaLib
{
    public class oUnit
    {
        public Guid UnitID;
        public string Name;
        public UnitStat Stats;
        public GemColor Color;
        public int CurMana;
        public int CurHealth;
        public Guid ArmorID;
        public Guid WeaponID;
        public Guid TrinketID;
        public List<oUnitStatus> Statuses;
        public List<oUnitAbility> Abilities;

        public oUnit()
        {
            UnitID = Guid.NewGuid();
            Name = "";
            Stats = new UnitStat();
            Color = GemColor.none;
            CurMana = 0;
            CurHealth = 0;
            ArmorID = Guid.Empty;
            WeaponID = Guid.Empty;
            TrinketID = Guid.Empty;
            Statuses = new List<oUnitStatus>();
            Abilities = new List<oUnitAbility>();
        }
    }
}
