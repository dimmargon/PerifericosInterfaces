using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace p4
{
    public partial class Form1 : Form
    {
        public int keycode;
        public char pressedKey;
        public Point clickPosition;
        public Point currentPosition;
        Pen penR = new Pen(Color.Red);

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
                leftClick.ForeColor = Color.Green;
            }
            if (e.Button.ToString().Equals("Middle"))
            {
                middleClick.ForeColor = Color.Green;
            }
            if (e.Button.ToString().Equals("Right"))
            {
                rightClick.ForeColor = Color.Green;
            }


        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = new Point(e.X, e.Y);
            pictureBox1.Refresh();

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button.ToString().Equals("Left"))
            {
                leftClick.ForeColor = Color.Black;
            }
            if (e.Button.ToString().Equals("Middle"))
            {
                middleClick.ForeColor = Color.Black;
            }
            if (e.Button.ToString().Equals("Right"))
            {
                rightClick.ForeColor = Color.Black;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EntryTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EntryTbx_MouseClick(object sender, MouseEventArgs e)
        {
            EntryTbx.Text = "";
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(penR, clickPosition, currentPosition);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            clickPosition = new Point(e.X, e.Y);
        }
    }
}
