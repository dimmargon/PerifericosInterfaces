using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Hyperic.Sigar;

namespace p3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cPUInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sigar sigar = new Sigar();

            Hyperic.Sigar.CpuInfo[] infos =
                sigar.CpuInfoList();

            richTextBox1.AppendText(infos.Length + " total CPUs..");

            foreach (Hyperic.Sigar.CpuInfo info in infos)
            {
                richTextBox1.AppendText("Vendor........" + info.Vendor);
                richTextBox1.AppendText("Model........." + info.Model);
                richTextBox1.AppendText("Mhz..........." + info.Mhz);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
