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

namespace Game_1._2
{
    public partial class Form1 : Form
    {
        public Canvas c = null;
        Sprite p1;
        Chaser p2;
        Bullet b1;
        Bullet b2;

        public Form1()
        {

            InitializeComponent();
            c = new Canvas(this);
            p1 = new Sprite(player);
            p2 = new Chaser(player2);
            b1 = new Bullet(Bulletpicture, 5, 5);
            c.Add(p1);
            c.Add(p2);
            c.Add(b1);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value++;
            // let the canvas do all the work
            c.tick();
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Shift && progressBar1.Value > 2)
            {
                p1.m_speed = 10;
                progressBar1.Value--;
            }


            if (e.KeyCode == Keys.A)
            {
                p1.moveleft();
            }
            if (e.KeyCode == Keys.D)
            {
                p1.moveright();
            }
            if (e.KeyCode == Keys.W)
            {
                p1.moveup();
            }
            if (e.KeyCode == Keys.S)
            {
                p1.movedown();
            }
            if (e.KeyCode == Keys.Left)
            {
                p2.moveleft();
            }
            if (e.KeyCode == Keys.Right)
            {
                p2.moveright();
            }
            if (e.KeyCode == Keys.Up)
            {
                p2.moveup();
            }
            if (e.KeyCode == Keys.Down)
            {
                p2.movedown();
            }
            if (e.KeyCode == Keys.Space)
            {
                PictureBox p = new PictureBox();
                p.Location = player.Location;
                p.Width = Bulletpicture.Width;
                p.Size = Bulletpicture.Size;
                p.BackColor = Bulletpicture.BackColor;
                p.Top = player.Location.X;
                p.Left = player.Location.Y;
                p.Width = Bulletpicture.Width;
                p.Height = Bulletpicture.Height;
                p.BackColor = Bulletpicture.BackColor;
                p.SizeMode = Bulletpicture.SizeMode;
                if (Bulletpicture.Image != null)
                    p.Image = Bulletpicture.Image;
                else
                    p.Image == null
                p.Name = Bulletpicture.Name;
                p.Visible = true;
                Controls.Add(p);
                c.Add(new Bullet(p,100,0));
            }
        }
    }

}