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

namespace sesion6ReadWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public static class Globals
        {
            public static OpenFileDialog fdlg;
        }
        
        private void Cargar_Click(object sender, EventArgs e)
        {

            Globals.fdlg = new OpenFileDialog();
            Globals.fdlg.Title = "Escoger fichero";
            Globals.fdlg.InitialDirectory = @"c:/users/dimas/desktop";
            Globals.fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            Globals.fdlg.FilterIndex = 2;
            Globals.fdlg.RestoreDirectory = true;;
            if (Globals.fdlg.ShowDialog() == DialogResult.OK)
            {
                String line;
                StreamReader sr = new StreamReader(Globals.fdlg.FileName);
                line = sr.ReadLine();
                while (line != null)
                {
                    pan_edition.Text = pan_edition.Text + "\n" + line;
                    line = sr.ReadLine();
                }
                sr.Close();
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            pan_edition.Text = "";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //Pasamos el nombre del fichero y la ruta al constructor
            StreamWriter sw = new StreamWriter(Globals.fdlg.FileName);
            //Escribimos el texto
            sw.Write(pan_edition.Text);
            //Cerramos fichero
            sw.Close();
        }

    }
}
