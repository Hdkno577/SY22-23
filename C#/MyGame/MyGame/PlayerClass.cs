using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyGame
{
    internal class PlayerClass
    {
        public int m_health = 0;
        public PictureBox m_picture;
        public Point m_location;
        public int m_speed = 5;
        public int m_x = 0;
        public int m_y = 0;
        public Form1 m_parent;
        public PlayerClass(PictureBox picture, Form1 parent)
        {
            m_picture = picture;
            m_location = picture.Location;
            m_parent = parent;
        }
        public PlayerClass(PictureBox picture, Form1 parent, int x, int y, int speed) : this(picture, parent)
        {           
            m_x = x;
            m_y = y;
            m_speed = speed;
        }
        public void tick()
        {
            move();
        }
        public void move()
        {
            if (!m_parent.isClear(m_picture, -m_speed, 0))
            {
                m_x *= -1;
                m_y *= -1;
                return;
            } 
            m_location = new Point(m_location.X + m_speed * m_x, m_location.Y + m_speed * m_y);
            m_picture.Location = m_location;
        }
        public void moveLeft()
        {
            if (!m_parent.isClear(m_picture, m_speed * m_x, m_speed * m_y))
                return;
            m_location = new Point(m_location.X - m_speed, m_location.Y);
            m_picture.Location = m_location;
        }        
        public void moveRight()
        {
            if (!m_parent.isClear(m_picture, + m_speed, 0))
                return; 
            m_location = new Point(m_location.X + m_speed, m_location.Y);
            m_picture.Location = m_location;
        }
        public void moveUp()
        {
            if (!m_parent.isClear(m_picture, - m_speed, 0))
                return;
            m_location = new Point(m_location.X, m_location.Y - m_speed);
            m_picture.Location = m_location;
        }
        public void moveDown()
        {
            if (!m_parent.isClear(m_picture, + m_speed, 0))
                return;
            m_location = new Point(m_location.X, m_location.Y + m_speed);
            m_picture.Location = m_location;
        }
    }
}