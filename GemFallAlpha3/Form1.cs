using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GemFallAlpha3
{
    public partial class Form1 : Form
    {
        int gridSize = 32;
        oGrid gems;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateNewGrid();
        }

        private void CreateNewGrid()
        {
            gems = new oGrid(8, 8);
            gems.Create();
            //oScanGems scan = gems.ToScanGems();

            gems.FindMatches();

            DrawScan(gems);
        }

        private void DrawScan(oGrid scan)
        {
            Image img = new Bitmap(500, 500);
            Graphics g = Graphics.FromImage(img);
            Rectangle rect;
            List<GemColorSimple> colors;

            foreach (oGem x in scan.Gems)
            {
                if (x.Color != GemColor.none)
                {
                    rect = new Rectangle(x.X * gridSize, x.Y * gridSize, gridSize - 1, gridSize - 1);

                    colors = x.Colors();
                    if (colors.Count == 1 || x.Color == GemColor.Rainbox)
                    {
                        g.FillRectangle(GetBrush(x.Color), rect);
                    }
                    else
                    {
                        g.FillRectangle(GetBrush((GemColor)colors[0]), rect);
                        g.FillRectangle(GetBrush((GemColor)colors[1]), new Rectangle(rect.X, rect.Y, gridSize / 2, gridSize));
                    }
                    //g.DrawString(x.Index.ToString(), this.Font, Brushes.Blue, rect);

                    if (x.HighestMatch() > 2)
                    {
                        g.DrawString(x.HighestMatch().ToString(), this.Font, Brushes.Black, new Rectangle(rect.X + (gridSize / 2), rect.Y, gridSize / 2, gridSize));
                    }
                    g.DrawRectangle(Pens.Black, rect);

                    if (x.isSelected)
                    {
                        g.DrawRectangle(Pens.Orange, rect);
                    }
                }
            }

            pictureBox1.BackgroundImage = img;
        }
        private SolidBrush GetBrush(GemColor color)
        {
            Color c = Color.Pink;

            switch (color)
            {
                case GemColor.Blue:
                    c = Color.FromArgb(30, 144, 255);
                    break;
                case GemColor.Red:
                    c = Color.FromArgb(220, 20, 60);
                    break;
                case GemColor.Green:
                    c = Color.FromArgb(107, 142, 35);
                    break;
                case GemColor.Yellow:
                    c = Color.FromArgb(255, 215, 0);
                    break;
                case GemColor.Brown:
                    c = Color.FromArgb(139, 69, 19);
                    break;
                case GemColor.Purple:
                    c = Color.FromArgb(153, 50, 204);
                    break;
                case GemColor.White:
                    c = Color.FromArgb(255, 255, 255);
                    break;
                case GemColor.Rainbox:
                    c = Color.FromArgb(255, 128, 0);
                    break;
                default:
                    c = Color.FromArgb(0, 0, 0);
                    break;
            }

            return new SolidBrush(c);
        }
          
        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateNewGrid();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int cnt = 0;

            gems.Create();
            gems.FindMatches();

            while (gems.Matches.Count > 0)
            {
                gems.Create();
                gems.FindMatches();
                cnt += 1;
            }

            DrawScan(gems);
            lblStableAttempts.Text = cnt.ToString() + " attempts";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            bool isSelected = false;
            oGem currentSelection = gems.GetSelected();

            oGem g = gems.Gem(coordinates.X / gridSize, coordinates.Y / gridSize);
            isSelected = g.isSelected;

            //a new gem is selected while another gem is already selected
            if (currentSelection != null && !isSelected)
            {
                //is the new selection next to the first?
                if (gems.isGemNearGem(currentSelection, g))
                {
                    //swap gems
                    gems.SwapGems(g.Index, currentSelection.Index);

                    gems.DeselectAll();

                    gems.FindMatches();
                    if (gems.Matches.Count == 0)
                    {
                        //swap gems
                        gems.SwapGems(g.Index, currentSelection.Index);
                    }

                    DrawScan(gems);

                    if (cbxAuto.Checked) { tmrFillEmpty.Enabled = true; }

                    return;
                }
            }

            gems.DeselectAll();
            g.isSelected = !isSelected;
            DrawScan(gems);
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            gems.FindMatches();
            bool foundMatches = false;

            pnlOptions.Height = 0;

            foreach (oGem g in gems.Gems)
            {
                foreach (KeyValuePair<ScanKey, ScanMatch> m in g.Matches)
                {
                    if (m.Value.Strength > 2)
                    {
                        foundMatches = true;
                        g.Color -= (GemColor)m.Value.Color;
                        gems.Gem(g.X, g.Y).Color = g.Color;
                        g.Matches.Clear();
                        break;
                    }
                }
            }
            DrawScan(gems);
            if (cbxLoop.Checked && foundMatches)
            {
                tmrMatches.Enabled = true;
            }
            else
            {
                pnlOptions.Height = 664;
                tmrBestMove.Enabled = true;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            gems.DropDown();
            gems.FindMatches();
            DrawScan(gems);
            if (cbxLoop.Checked)
            {
                tmrDown.Enabled = true;
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            gems.FillEmpty();
            gems.FindMatches();
            DrawScan(gems);
            if (cbxLoop.Checked)
            {
                tmrFillEmpty.Enabled = true;
            }
        }

        private void tmrMatches_Tick(object sender, EventArgs e)
        {
            tmrMatches.Enabled = false;
            btnDown.PerformClick();
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            tmrDown.Enabled = false;
            btnFill.PerformClick();
        }

        private void tmrFillEmpty_Tick(object sender, EventArgs e)
        {
            tmrFillEmpty.Enabled = false;
            btnMatches.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScanMove best;

            gems.FindMoves();

            best = gems.BestMove();

            gems.Gems[best.Index].isSelected = true;
            if (best.Direction == ScanDirection.Right)
            {
                gems.Gems[best.Index + 1].isSelected = true;
            }
            if (best.Direction == ScanDirection.Down)
            {
                gems.Gems[best.Index + gems.Width].isSelected = true;
            }

            DrawScan(gems);
        }

        private void tmrBestMove_Tick(object sender, EventArgs e)
        {
            tmrBestMove.Enabled = false;

            gems.FindMoves();

            if (gems.Moves.Count > 0)
            {
                ScanMove best;
                best = gems.BestMove();

                if (best.Direction == ScanDirection.Right)
                {
                    gems.SwapGems(best.Index, best.Index + 1);
                }
                if (best.Direction == ScanDirection.Down)
                {
                    gems.SwapGems(best.Index, best.Index + gems.Width);
                }

                gems.FindMatches();

                DrawScan(gems);

                if (cbxLoop.Checked && cbxAuto.Checked)
                {
                    tmrFillEmpty.Enabled = true;
                }
            }
        }
    }
}
