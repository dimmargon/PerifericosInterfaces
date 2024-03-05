using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InfoSistema;

namespace p2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DatosSis_Click(object sender, EventArgs e)
        {
            irInforSistema info = new irInforSistema();
            richTextBox1.AppendText("Nombre del PC: " + info.NombreComputador + "\n");
            richTextBox1.AppendText("Cantidad de procesadores: " + info.CantidadProcesadores + "\n");
            richTextBox1.AppendText("DIrectorio del SO: " + info.DirectorioSistemaOperativo + "\n");
            richTextBox1.AppendText("Fabricante del PC: " + info.FabricanteComputador + "\n");
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Acerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESTE BOTON ES INUTIL... JAJAJA, ADIOS");
            this.Close();
        }
    }
}
