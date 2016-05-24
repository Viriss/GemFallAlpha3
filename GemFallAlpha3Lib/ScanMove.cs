
namespace GemFallAlphaLib
{
    public struct ScanMove
    {
        public int Index;
        public ScanDirection Direction;
        public GemColor Color;
        public int Score;
        public int Total;

        public ScanMove(int Index, ScanDirection Direction, GemColor Color, int Score, int Total)
        {
            this.Index = Index;
            this.Direction = Direction;
            this.Color = Color;
            this.Score = Score;
            this.Total = Total;
        }
    }
}
