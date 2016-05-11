
namespace GemFallAlphaLib
{
    public struct ScanMove
    {
        public int Index;
        public ScanDirection Direction;
        public GemColor Color;
        public int Score;

        public ScanMove(int Index, ScanDirection Direction, GemColor Color, int Score)
        {
            this.Index = Index;
            this.Direction = Direction;
            this.Color = Color;
            this.Score = Score;
        }
    }
}
