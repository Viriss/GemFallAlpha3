using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemFallAlpha3
{
    public static class Global
    {
        public static GemColor RandomColor()
        {
            Array colors = Enum.GetValues(typeof(GemColor));
            return (GemColor)colors.GetValue(Rand.rnd.Next(1, colors.Length));
        }
        public static GemColor RandomColorSimple()
        {
            Array colors = Enum.GetValues(typeof(GemColorSimple));
            return (GemColor)colors.GetValue(Rand.rnd.Next(1, colors.Length));
        }
    }

    public static class Rand
    {
        public static Random rnd = new Random();
    }
}
