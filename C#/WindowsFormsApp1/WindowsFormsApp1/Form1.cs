using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amt = 0;
            double.TryParse(amountBox.Text, out amt);
            double fee = 0;
            double.TryParse(feeBox.Text, out fee);
            feeBox.Text = (amt * 0.03).ToString("c2");
            this.BackColor = SystemColors.Control;
            if (amt > 500)
                this.BackColor = Color.Red;
            Clear();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Clear()
        { 
            nameBox.Clear(); 
            ccBox.Clear(); 
            amountBox.Clear();
            ExpBox.Clear();
            ZipBox.Clear();
        }

        private void feeBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
