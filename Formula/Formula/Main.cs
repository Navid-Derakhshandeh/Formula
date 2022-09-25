using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ohmsLawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCVP frm = new RCVP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void maximumPathLossAndDistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maximum_Path_Loss_And_Distance frm = new Maximum_Path_Loss_And_Distance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

    }
}
