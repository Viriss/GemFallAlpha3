using System;
using System.Collections.Generic;
using System.Text;

namespace GemFallAlphaLib
{

    public enum TeamType { Hero, Monster }

    public class oTeam
    {
        public Guid TeamID;
        public string UserName;
        public List<oUnit> Units;
        public TeamType Type;
        public oManaPool ManaPool;

        public oTeam()
        {
            TeamID = Guid.NewGuid();
            UserName = "";
            Units = new List<oUnit>();
            Type = TeamType.Monster;
            ManaPool = new oManaPool();
        }
    }
}
