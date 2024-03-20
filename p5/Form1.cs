using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace p5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena;
            int numero;

            cadena = comboBox4.SelectedItem.ToString();
            serialPort1.PortName = cadena;
            //serialPort1.PortName = "COM7";

            cadena = comboBox1.SelectedItem.ToString();
            numero = Convert.ToInt16(cadena);
            serialPort1.BaudRate = numero;
            //serialPort1.BaudRate = 9600;

            cadena = comboBox2.SelectedItem.ToString();
            numero = Convert.ToInt16(cadena);
            serialPort1.DataBits = numero;

            cadena = comboBox5.SelectedItem.ToString();
            if (cadena == "Uno")
            {
                serialPort1.StopBits = System.IO.Ports.StopBits.One;
            }
            else
            {
                if (cadena == "Dos")
                {
                    serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                }
                else
                {
                    serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                }
            }

            cadena = comboBox3.SelectedItem.ToString();
            if (cadena == "Impar")
            {
                serialPort1.Parity = System.IO.Ports.Parity.Odd;
            }
            else
            {
                if (cadena == "Par")
                {
                    serialPort1.Parity = System.IO.Ports.Parity.Even;
                }
                else
                {
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                }
            }

            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                button1.Enabled = true;
                button2.Enabled = false;
                textBox1.ReadOnly = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!serialPort1.IsOpen) return;

            char[] tecla_pulsada = new char[1];

            tecla_pulsada[0] = e.KeyChar;
            textBox1.AppendText(e.KeyChar.ToString());

            serialPort1.Write(tecla_pulsada, 0, 1);
        }

        String RxString;
        private void DisplayText(object sender, EventArgs e)
        {
            textBox2.AppendText(RxString);
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            //int dato = serialPort1.ReadByte();

            this.Invoke(new EventHandler(DisplayText));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
            this.Close();
        }
    }
}
