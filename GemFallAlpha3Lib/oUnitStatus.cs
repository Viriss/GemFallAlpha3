using System;
using System.Collections.Generic;
using System.Text;

namespace GemFallAlphaLib
{
    public class oUnitStatus
    {
        public StatType Stat;
        public int Modifier;
        public int TurnsRemaining;
        public bool isDone;

        //TODO: Source of status

        public void NewTurn()
        {
            if (TurnsRemaining > 0)
            {
                TurnsRemaining -= 1;
                if (TurnsRemaining == 0) { isDone = true; }
            }
        }
    }
}
