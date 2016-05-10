using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemFallAlpha3
{
    public struct ScanKey
    {
        GemColorSimple Color;
        ScanDirection Direction;

        public ScanKey(GemColorSimple Color, ScanDirection Direction)
        {
            this.Color = Color;
            this.Direction = Direction;
        }
    }
}
