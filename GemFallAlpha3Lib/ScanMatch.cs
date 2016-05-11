
namespace GemFallAlphaLib
{
    public enum ScanDirection { Up, Down, Left, Right }

    public struct ScanMatch
    {
        public int Index;
        public ScanDirection Direction;
        public GemColorSimple Color;
        public int Strength;

        public ScanMatch(int Index, GemColorSimple Color, ScanDirection Direction)
        {
            this.Index = Index;
            this.Direction = Direction;
            this.Color = Color;
            this.Strength = 0;
        }

        public void Add()
        {
            this.Strength += 1;
        }
    }
}
