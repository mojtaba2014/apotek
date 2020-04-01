using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Afo
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        Form6 f6 = new Form6();
        Form7 f7 = new Form7();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ForsikringerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void FirmaerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();
        }

        private void LægeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KøbtemedecinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.ShowDialog();
        }

        private void TransporttilandredepotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f7.ShowDialog();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f6.ShowDialog();
        }

        private void KøbtevarertoolStripSeparator2_Click(object sender, EventArgs e)
        {

        }
    }
}
