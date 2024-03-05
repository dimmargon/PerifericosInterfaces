using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace p4
{
    public partial class Form1 : Form
    {
        public int keycode;
        public char pressedKey;
        public Point latestPoint;
        public int arriba;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void EntryTbx_KeyDown(object sender, KeyEventArgs e)
        {
            keycode = e.KeyValue;
            ScanCodeTbx.Text = keycode.ToString();
            StatusTbx.Text = "Key Pressed";
        }

        private void EntryTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            pressedKey = e.KeyChar;
            KeyPressedTbx.Text = pressedKey.ToString();
        }

        private void EntryTbx_KeyUp(object sender, KeyEventArgs e)
        {
            KeyReleasedTbx.Text = Convert.ToString(pressedKey);
            pressedKey = ' ';
            EntryTbx.Text = "";
            StatusTbx.Text = "";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button.ToString().Equals("Left"))
            {
                label2.ForeColor = Color.Green;
            }
            if (e.Button.ToString().Equals("Middle"))
            {
                label6.ForeColor = Color.Green;
            }
            if (e.Button.ToString().Equals("Right"))
            {
                label7.ForeColor = Color.Green;
            }


        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (arriba == 1)
            {
                g.DrawLine(Pens.Red, latestPoint, e.Location);
                pictureBox1.Refresh();
                g.DrawLine(Pens.Red, latestPoint, e.Location);
            }


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button.ToString().Equals("Left"))
            {
                label2.ForeColor = Color.Black;
            }
            if (e.Button.ToString().Equals("Middle"))
            {
                label6.ForeColor = Color.Black;
            }
            if (e.Button.ToString().Equals("Right"))
            {
                label7.ForeColor = Color.Black;
            }
        }
    }
}
