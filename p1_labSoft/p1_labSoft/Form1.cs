using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.Management;

namespace p1_labSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Suscripción al evento Load
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Valor", "Valor");

        }

        public ArrayList GetStuff(string queryObject)
        {
            ManagementObjectSearcher
           searcher; int i = 0;
            ArrayList hd = new ArrayList();
            try
            {
                searcher = new ManagementObjectSearcher("SELECT * FROM " + queryObject);
                foreach (ManagementObject wmi_HD in searcher.Get())
                {
                    i++;
                    PropertyDataCollection searcherProperties = wmi_HD.Properties;
                    foreach (PropertyData sp in searcherProperties)
                    {
                        hd.Add(sp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return hd;
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            // Limpiar DataGridView antes de agregar nuevos datos
            dataGridView1.Rows.Clear();

            // Obtener la API seleccionada del ComboBox
            string selectedAPI = comboBox1.SelectedItem.ToString();

            // Llamar al método GetStuff y obtener las propiedades
            ArrayList properties = GetStuff(selectedAPI);

            // Agregar las propiedades al DataGridView
            foreach (PropertyData property in properties)
            {
                dataGridView1.Rows.Add(property.Name, property.Value);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
