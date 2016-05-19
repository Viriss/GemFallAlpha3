using System;
using System.Collections.Generic;

namespace GemFallAlphaLib
{
    public enum GemColor
    {
        none = 0,

        Red = 1,
        Yellow = 2,
        Brown = 4,
        Green = 8,
        Blue = 16,
        Purple = 32,
        White = 64,

        RedYellow = Red + Yellow,
        RedBrown = Red + Brown,
        RedGreen = Red + Green,
        RedBlue = Red + Blue,
        RedPurple = Red + Purple,

        YellowBrown = Yellow + Brown,
        YellowGreen = Yellow + Green,
        YellowBlue = Yellow + Blue,
        YellowPurple = Yellow + Purple,

        BrownGreen = Brown + Green,
        BrownBlue = Brown + Blue,
        BrownPurple = Brown + Purple,

        GreenBlue = Green + Blue,
        GreenPurple = Green + Purple,

        BluePurple = Blue + Purple,

        Rainbox = Red + Yellow + Brown + Green + Blue + Purple

        /*
        ,WhiteRed = White + Red
        ,WhiteYellow = White + Yellow
        ,WhiteBrown = White + Brown
        ,WhiteGreen = White + Green
        ,WhiteBlue = White + Blue
        ,WhitePurple = White + Purple
         */
    }
    public enum GemColorSimple
    {
        none = 0,

        Red = 1,
        Yellow = 2,
        Brown = 4,
        Green = 8,
        Blue = 16,
        Purple = 32,
        White = 64
    }

    public class oGem
    {
        public int Index;
        public GemColor Color;
        public int X { get { return Index % Width; } }
        public int Y { get { return (Index - X) / Width; } }
        public int Width;
        public Dictionary<ScanKey, ScanMatch> Matches;
        public bool isDestroyed;
        public bool isSelected;
        public bool isEnchanted;

        public oGem()
        {
            Index = -1;
            Color = GemColor.none;
            Width = 1;
            Matches = new Dictionary<ScanKey, ScanMatch>();
            isDestroyed = false;
            isSelected = false;
            isEnchanted = false;
        }
        public oGem(int Index, GemColor Color, int Width) :this()
        {
            this.Index = Index;
            this.Color = Color;
            this.Width = Width;
        }

        public List<GemColorSimple> Colors()
        {
            List<GemColorSimple> list = new List<GemColorSimple>();
            foreach (int c in Enum.GetValues(typeof(GemColorSimple)))
            {
                if (c > 0 && ((int)this.Color & c) == c)
                {
                    list.Add((GemColorSimple)c);
                }
            }
            return list;
        }


        public void AddMatch(GemColorSimple Color, ScanDirection Direction)
        {
            ScanKey key = new ScanKey(Color, Direction);
            if (!Matches.ContainsKey(key))
            {
                Matches.Add(key, new ScanMatch(Index, Color, Direction));
            }
            ScanMatch sm = Matches[key];
            sm.Add();
            Matches[key] = sm;
        }
        public GemColorSimple GetCrossMatchColor()
        {
            foreach (KeyValuePair<ScanKey, ScanMatch> vertMatch in Matches)
            {
                if (vertMatch.Value.Strength > 2 && (
                    vertMatch.Value.Direction == ScanDirection.Left || vertMatch.Value.Direction == ScanDirection.Right))
                {
                    foreach (KeyValuePair<ScanKey, ScanMatch> horMatch in Matches)
                    {
                        if (horMatch.Value.Strength > 2 && (
                            horMatch.Value.Direction == ScanDirection.Up || horMatch.Value.Direction == ScanDirection.Down))
                        {
                            if (vertMatch.Value.Color == horMatch.Value.Color) { return vertMatch.Value.Color; }
                        }
                    }
                }
            }
            return GemColorSimple.none;
        }
        public int HighestMatch()
        {
            int val = 0;
            List<ScanKey> keys = new List<ScanKey>(Matches.Keys);
            foreach (ScanKey key in keys)
            {
                if (Matches[key].Strength > 2 && (Matches[key].Direction == ScanDirection.Up || Matches[key].Direction == ScanDirection.Down))
                    foreach (ScanKey innerKey in keys)
                    {
                        if (Matches[innerKey].Strength > 2 && (Matches[innerKey].Direction == ScanDirection.Left || Matches[innerKey].Direction == ScanDirection.Right))
                        {
                            if (Matches[key].Color == Matches[innerKey].Color)
                            {
                                int xVal = Matches[key].Strength + Matches[innerKey].Strength - 1;
                                if (xVal > val) { val = xVal; }
                            }
                        }
                    }
                if (Matches[key].Strength > val) { val = Matches[key].Strength; }
            }
            return val;
        }
        public bool isColorMatch(List<GemColorSimple> matchColors)
        {
            List<GemColorSimple> myColors = Colors();

            foreach(GemColorSimple c in matchColors)
            {
                if (myColors.Contains(c)) return true;
            }
            return false;
        }

        public void SetColor(GemColor color)
        {
            this.Color = color;
            isDestroyed = false;
            isSelected = false;
            isEnchanted = false;
        }

        public oGem ToCopy()
        {
            oGem g = new oGem(Index, Color, Width);
            //TODO: Copy enchantment
            return g;
        }
    }
}
