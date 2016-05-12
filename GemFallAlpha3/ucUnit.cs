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
    public partial class ucUnit : UserControl
    {
        public oUnit Unit = new oUnit();

        public ucUnit()
        {
            InitializeComponent();
        }

        private void ucUnit_Load(object sender, EventArgs e)
        {
            UpdateControl();
        }

        public void UpdateControl()
        {
            lblName.Text = Unit.Name;
            lblHealth.Text = Unit.CurHealth.ToString() + " / " + Unit.Stats.MaxHealth.ToString();
            SetUnitColor();
        }
        public void SetUnitColor()
        {
            switch(Unit.Color)
            {
                case GemColor.Blue:
                    label1.BackColor = Color.Blue;
                    break;
                case GemColor.Green:
                    label1.BackColor = Color.Green;
                    break;
                case GemColor.Purple:
                    label1.BackColor = Color.Purple;
                    break;
                case GemColor.Red:
                    label1.BackColor = Color.Red;
                    break;
                case GemColor.Yellow:
                    label1.BackColor = Color.Yellow;
                    break;
                case GemColor.Brown:
                    label1.BackColor = Color.Brown;
                    break;
            }
        }
    }
}
