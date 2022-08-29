using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 5;
            if (e.Shift && progressBar1.Value > 2)
            {
                speed = 10;
                progressBar1.Value--;
            }
            if (e.KeyCode == Keys.A | e.KeyCode == Keys.Left)
            {
                playerBox.Location = new Point(playerBox.Location.X - speed, playerBox.Location.Y);
            }
            if (e.KeyCode == Keys.D | e.KeyCode == Keys.Right)
            {
                playerBox.Location = new Point(playerBox.Location.X + speed, playerBox.Location.Y);
            }
            if (e.KeyCode == Keys.W | e.KeyCode == Keys.Up)
            {
                playerBox.Location = new Point(playerBox.Location.X , playerBox.Location.Y - speed);
            }
            if (e.KeyCode == Keys.S | e.KeyCode == Keys.Down)
            {
                playerBox.Location = new Point(playerBox.Location.X , playerBox.Location.Y + speed);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                Enabled = false;
            }
        }
    }
}
