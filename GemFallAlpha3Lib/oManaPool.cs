using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GemFallAlphaLib
{
    public class oManaPool
    {
        public Dictionary<GemColorSimple, int> Mana;
        int Size = 25;

        public oManaPool()
        {
            Mana = new Dictionary<GemColorSimple, int>();
            foreach(GemColorSimple color in Enum.GetValues(typeof(GemColorSimple)))
            {
                Mana.Add(color, 0);
            }
        }

        public void Add(GemColorSimple Color, int Value)
        {
            int x = Mana[Color] + Value;
            if (x > Size) { x = Size; }
            Mana[Color] = x;
        }
        public void Subtract(GemColorSimple Color, int Value)
        {
            int x = Mana[Color] - Value;
            if (x < 0) { x = 0; }
            Mana[Color] = x;
        }

    }
}
