using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Anteckningar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void automatiskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void omAnteckningarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                richTextBox1.Lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
            }
        }

        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DialogResult  dialogResult =  saveFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, richTextBox1.Lines);

            }
        }
    }
}
