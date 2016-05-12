using System;
using System.Collections.Generic;
using System.Text;

namespace GemFallAlphaLib
{
    public class oTeam
    {
        public Guid TeamID;
        public string UserName;
        public List<oUnit> Units;

        public oTeam()
        {
            TeamID = Guid.NewGuid();
            UserName = "";
            Units = new List<oUnit>();

        }
    }
}
