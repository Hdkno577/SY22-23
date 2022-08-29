using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currecy_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double usd = 0;
            double pnd = 0;
            double euro = 0;
            double rbl = 0;
            double yen = 0;
            double can = 0;
            double aus = 0;
            double.TryParse(usdBox.Text, out usd);
            usdBox.Text = (usd).ToString("c2");
            double.TryParse(poundBox.Text, out pnd);
            poundBox.Text = (usd * 0.85).ToString("n2");
            double.TryParse(euroBox.Text, out euro);
            euroBox.Text = (usd).ToString("n2");
            double.TryParse(rubleBox.Text, out rbl);
            rubleBox.Text = (usd * 60.38).ToString("n2");
            double.TryParse(yenBox.Text, out yen);
            yenBox.Text = (usd * 136.71).ToString("n2");
            double.TryParse(canBox.Text, out can);
            canBox.Text = (usd * 1.29).ToString("n2");
            double.TryParse(ausBox.Text, out aus);
            ausBox.Text = (usd * 1.44).ToString("n2");
        }
    }
}
