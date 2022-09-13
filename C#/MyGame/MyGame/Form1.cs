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

namespace MyGame
{
    public partial class Form1 : Form
    {
        PlayerClass p1;
        PlayerClass p2;
        ArrayList objects = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            p1 = new PlayerClass(player1Box, this, 1, 1, 5);
            p2 = new PlayerClass(player2Box, this, -1, 1, 5);
            objects.Add(p1);
            objects.Add(p2);
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
                p1.moveLeft();
            }
            if (e.KeyCode == Keys.D)
            {
                p1.moveRight();
            }
            if (e.KeyCode == Keys.W)
            {
                p1.moveUp();
            }
            if (e.KeyCode == Keys.S)
            {
                p1.moveDown();
            }
            if (e.Shift && progressBar1.Value > 2)
            {
                p1.m_speed = 10;
                progressBar1.Value--;
            }
            if (e.KeyCode == Keys.Left)
            {
                p2.moveLeft();
            }
            if (e.KeyCode == Keys.Right)
            {
                p2.moveRight();
            }
            if (e.KeyCode == Keys.Up)
            {
                p2.moveUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                p2.moveDown();
            }
        }
        public bool isClear(PictureBox P, int x, int y)
        {
            foreach (var item in Controls)
            {
                if (typeof(PictureBox) == item.GetType() && P != item)
                {
                    PictureBox pictureBox = (PictureBox)item;
                    Rectangle newRect = new Rectangle(P.Location.X + x, P.Location.Y + y, pictureBox.Width, pictureBox.Height);
                    if (pictureBox.Bounds.IntersectsWith(newRect))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            foreach (PlayerClass item in objects)
            {
                if (isClear(item.m_picture, 0, 5))
                    item.tick();
            }
        }        
    }
}