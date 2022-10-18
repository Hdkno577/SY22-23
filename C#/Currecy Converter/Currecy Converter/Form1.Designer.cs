namespace Currecy_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.usdBox = new System.Windows.Forms.TextBox();
            this.poundBox = new System.Windows.Forms.TextBox();
            this.euroBox = new System.Windows.Forms.TextBox();
            this.rubleBox = new System.Windows.Forms.TextBox();
            this.yenBox = new System.Windows.Forms.TextBox();
            this.canBox = new System.Windows.Forms.TextBox();
            this.ausBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "£";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "₽";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "¥";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "C$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "A$";
            // 
            // usdBox
            // 
            this.usdBox.Location = new System.Drawing.Point(200, 205);
            this.usdBox.Name = "usdBox";
            this.usdBox.Size = new System.Drawing.Size(100, 22);
            this.usdBox.TabIndex = 8;

            // 
            // poundBox
            // 
            this.poundBox.Location = new System.Drawing.Point(493, 114);
            this.poundBox.Name = "poundBox";
            this.poundBox.Size = new System.Drawing.Size(100, 22);
            this.poundBox.TabIndex = 9;

            // 
            // euroBox
            // 
            this.euroBox.Location = new System.Drawing.Point(493, 150);
            this.euroBox.Name = "euroBox";
            this.euroBox.Size = new System.Drawing.Size(100, 22);
            this.euroBox.TabIndex = 10;

            // 
            // rubleBox
            // 
            this.rubleBox.Location = new System.Drawing.Point(493, 191);
            this.rubleBox.Name = "rubleBox";
            this.rubleBox.Size = new System.Drawing.Size(100, 22);
            this.rubleBox.TabIndex = 11;

            // 
            // yenBox
            // 
            this.yenBox.Location = new System.Drawing.Point(493, 223);
            this.yenBox.Name = "yenBox";
            this.yenBox.Size = new System.Drawing.Size(100, 22);
            this.yenBox.TabIndex = 12;

            // 
            // canBox
            // 
            this.canBox.Location = new System.Drawing.Point(493, 256);
            this.canBox.Name = "canBox";
            this.canBox.Size = new System.Drawing.Size(100, 22);
            this.canBox.TabIndex = 13;

            // 
            // ausBox
            // 
            this.ausBox.Location = new System.Drawing.Point(493, 292);
            this.ausBox.Name = "ausBox";
            this.ausBox.Size = new System.Drawing.Size(100, 22);
            this.ausBox.TabIndex = 14;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ausBox);
            this.Controls.Add(this.canBox);
            this.Controls.Add(this.yenBox);
            this.Controls.Add(this.rubleBox);
            this.Controls.Add(this.euroBox);
            this.Controls.Add(this.poundBox);
            this.Controls.Add(this.usdBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox usdBox;
        private System.Windows.Forms.TextBox poundBox;
        private System.Windows.Forms.TextBox euroBox;
        private System.Windows.Forms.TextBox rubleBox;
        private System.Windows.Forms.TextBox yenBox;
        private System.Windows.Forms.TextBox canBox;
        private System.Windows.Forms.TextBox ausBox;
    }
}

