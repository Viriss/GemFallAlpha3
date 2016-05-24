using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GemFallAlphaLib;

namespace GemFallAlpha3
{
    public partial class ucManaPool : UserControl
    {
        public oManaPool Pool = new oManaPool();

        public ucManaPool()
        {
            InitializeComponent();
        }

        public void RefreshPool()
        {
            lblBlue.Text = Pool.Mana[GemColorSimple.Blue].ToString();
            lblRed.Text = Pool.Mana[GemColorSimple.Red].ToString();
            lblYellow.Text = Pool.Mana[GemColorSimple.Yellow].ToString();
            lblPurple.Text = Pool.Mana[GemColorSimple.Purple].ToString();
            lblGreen.Text = Pool.Mana[GemColorSimple.Green].ToString();
            lblBrown.Text = Pool.Mana[GemColorSimple.Brown].ToString();
        }
    }
}
