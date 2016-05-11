
namespace GemFallAlphaLib
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
