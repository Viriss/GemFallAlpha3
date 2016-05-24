using System;
using System.Collections.Generic;

namespace GemFallAlphaLib
{
    public class oGrid
    {
        public int Height;
        public int Width;
        public oGem[] Gems;
        public List<ScanMatch> Matches;
        public List<ScanMove> Moves;
        public int MultiColorChance = 0;

        public oGrid(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
            Gems = new oGem[Height * Width];
            Matches = new List<ScanMatch>();
            Moves = new List<ScanMove>();

            for (int i = 0; i < Height * Width; i++)
            {
                Gems[i] = new oGem(i, GemColor.none, Width);
            }
        }

        public ScanMove BestMove()
        {
            Moves.Sort((x, y) => y.Score.CompareTo(x.Score));

            //find non-swords first
            foreach (ScanMove m in Moves)
            {
                if (m.Score > 3 && (m.Color & GemColor.White) != GemColor.White) {
                    return m;
                }
            }
            //find swords last
            foreach (ScanMove m in Moves)
            {
                if (m.Score > 3 && (m.Color & GemColor.White) == GemColor.White)
                {
                    return m;
                }
            }

            //find swords
            foreach (ScanMove m in Moves)
            {
                if (m.Color == GemColor.White) {
                    return m;
                }
            }
            //find non-swords
            return Moves[0];
        }

        public void Create()
        {
            for(int i = 0; i < Height * Width; i++)
            {
                if (Rand.rnd.Next(100) < MultiColorChance)
                {
                    Gems[i].SetColor(Global.RandomColor());
                }
                else
                {
                    try
                    {
                        Gems[i].SetColor(Global.RandomColorSimple());
                    }
                    catch(Exception ex)
                    {
                     
                    }
                }
            }
        }
        public void DeselectAll()
        {
            foreach (oGem x in Gems)
            {
                x.isSelected = false;
            }
        }
        public void DropDown()
        {
            DropDownPass();
        }
        private void DropDownPass()
        {
            int count = 0;
            oGem A;
            oGem B;

            for (int y = Height - 1; y > 0; y--)
            {
                for (int x = 0; x < Width; x++)
                {
                    A = Gems[x + (y * Width)];
                    B = Gems[x + ((y - 1) * Width)];

                    if (A.Color == GemColor.none && B.Color != GemColor.none)
                    {
                        A.Color = B.Color;
                        B.Color = GemColor.none;
                        count += 1;
                    }
                }
            }

            if (count > 0) { DropDownPass(); }
        }
        public void FillEmpty()
        {
            foreach (oGem g in Gems)
            {
                if (g.Color == GemColor.none)
                {
                    if (Rand.rnd.Next(100) < MultiColorChance)
                    {
                        g.SetColor(Global.RandomColor());
                    }
                    else
                    {
                        g.SetColor(Global.RandomColorSimple());
                    }

                }
            }
        }
        public void FindMatches()
        {
            ScanRun();
            ScanGatherResults();
        }
        public void FindMoves()
        {
            int index;

            Moves.Clear();

            for(int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    index = x + (y * Width);

                    if (x < Width -1) {
                        ScanMove(index, index + 1);
                    }

                    if (y < Height - 1)
                    {
                        ScanMove(index, index + Width);
                    }
                }
            }
        }
        public oGem Gem(int X, int Y)
        {
            if (X < 0 || X >= Width) { return null; }
            if (Y < 0 || Y >= Height) { return null; }
            return Gems[X + (Y * Width)];
        }
        public int GetIndexFromDirection(int StartIndex, ScanDirection Direction)
        {
            int X = StartIndex % Width;
            int Y = (StartIndex - X) / Width;

            switch (Direction) {
                case ScanDirection.Down:
                    if (Gem(X, Y - 1) != null) { return ((Y - 1) * Width) + X; }
                    break;
                case ScanDirection.Left:
                    if (Gem(X - 1, Y) != null) { return (Y * Width) + X - 1; }
                    break;
                case ScanDirection.Right:
                    if (Gem(X + 1, Y) != null) { return (Y * Width) + X + 1; }
                    break;
                case ScanDirection.Up:
                    if (Gem(X, Y + 1) != null) { return ((Y + 1) * Width) + X; }
                    break;
            }

            return -1;
        }
        public oGem GetSelected()
        {
            foreach (oGem g in Gems)
            {
                if (g.isSelected) { return g; }
            }
            return null;
        }
        public int HighestScore()
        {
            int val = 0;
            int xValue = 0;
            foreach(ScanMatch x in Matches)
            {
                xValue = GetCrossValue(x);
                if (x.Strength + xValue > val) { val = x.Strength + xValue; }
            }
            return val;
        }
        private int GetCrossValue(ScanMatch Start)
        {
            foreach(ScanMatch x in Matches)
            {
                if (x.Index == Start.Index && x.Color == Start.Color)
                {
                    if (x.Direction != Start.Direction && x.Direction != OppositeDirection(Start.Direction))
                    {
                        if (x.Strength > 2) { return x.Strength; }
                    }
                }
            }
            return 0;
        }
        private ScanDirection OppositeDirection(ScanDirection Direction)
        {
            if (Direction == ScanDirection.Down) return ScanDirection.Up;
            if (Direction == ScanDirection.Up) return ScanDirection.Down;
            if (Direction == ScanDirection.Left) return ScanDirection.Right;
            if (Direction == ScanDirection.Right) return ScanDirection.Left;
            return 0;
        }

        public bool isGemNearGem(oGem first, oGem second)
        {
            if (first == null) { return false; }
            if (second == null) { return false; }

            if (Math.Abs(first.X - second.X) <= 1 && Math.Abs(first.Y - second.Y) == 0) { return true; }
            if (Math.Abs(first.X - second.X) == 0 && Math.Abs(first.Y - second.Y) <= 1) { return true; }

            return false;
        }
        public bool hasExtraTurnMove()
        {
            bool extraTurn = false;

            foreach (ScanMatch x in Matches)
            {
                if (x.Strength > 3) { extraTurn = true; break; }
            }

            return extraTurn;
        }
        public int Score()
        {
            int val = 0;
            /*
            foreach (ScanMatch x in Matches)
            {
                if (x.Strength > 2) { val += x.Strength; }
            }
            */
            foreach(oGem g in Gems)
            {
                if (g.HighestMatch() > 2) { val += 1; }
            }
            return val;
        }
        public void SwapGems(int IndexA, int IndexB)
        {
            GemColor tC = Gems[IndexA].Color;
            Gems[IndexA].Color = Gems[IndexB].Color;
            Gems[IndexB].Color = tC;

            //TODO: swap enchantment

        }
        public oGrid ToCopy()
        {
            oGrid myGrid = new oGrid(Height, Width);

            myGrid.MultiColorChance = this.MultiColorChance;

            for(int i = 0; i < Height * Width; i++)
            {
                myGrid.Gems[i] = Gems[i].ToCopy();
            }

            return myGrid;
        }

        private void DoScan(int FromIndex, GemColorSimple Color, ScanDirection Direction)
        {
            oGem g = Gems[FromIndex];
            int x = GetIndexFromDirection(FromIndex, Direction);

            if (x > -1)
            {
                oGem other = Gems[x];

                if (other.Colors().Contains(Color)) 
                {
                    g.AddMatch(Color, Direction);

                    switch(Direction)
                    {
                        case ScanDirection.Down:
                            other.AddMatch(Color, ScanDirection.Up);
                            break;
                        case ScanDirection.Up:
                            other.AddMatch(Color, ScanDirection.Down);
                            break;
                        case ScanDirection.Left:
                            other.AddMatch(Color, ScanDirection.Right);
                            break;
                        case ScanDirection.Right:
                            other.AddMatch(Color, ScanDirection.Left);
                            break;
                    }

                    DoScan(x, Color, Direction);
                }
            }
        }
        private void ScanRun()
        {
            foreach (oGem g in Gems)
            {
                g.Matches.Clear();
            }
            foreach (oGem g in Gems)
            {
                foreach (GemColorSimple color in g.Colors())
                {
                    DoScan(g.Index, color, ScanDirection.Down);
                    DoScan(g.Index, color, ScanDirection.Up);
                    DoScan(g.Index, color, ScanDirection.Right);
                    DoScan(g.Index, color, ScanDirection.Left);
                }
            }
        }
        private void ScanGatherResults()
        {
            Matches.Clear();
            foreach (oGem g in Gems)
            {
                foreach (KeyValuePair<ScanKey, ScanMatch> match in g.Matches)
                {
                    if (match.Value.Strength > 2)
                    {
                        Matches.Add(match.Value);
                    }
                }
            }
        }
        private void ScanMove(int IndexA, int IndexB)
        {
            oGrid tmp = this.ToCopy();
            ScanDirection dir = ScanDirection.Down;
            if (IndexA == IndexB -1) { dir = ScanDirection.Right; }

            tmp.SwapGems(IndexA, IndexB);
            tmp.FindMatches();
            if (tmp.Matches.Count > 0)
            {
                Moves.Add(new ScanMove(IndexA, dir, tmp.Gems[IndexB].Color, tmp.HighestScore(), tmp.Score()));
            }
        }
    }
}
