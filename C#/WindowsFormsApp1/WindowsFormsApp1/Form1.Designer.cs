namespace WindowsFormsApp1
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
            this.buyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ccBox = new System.Windows.Forms.TextBox();
            this.ExpBox = new System.Windows.Forms.TextBox();
            this.ZipBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.feeBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(12, 215);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(115, 35);
            this.buyButton.TabIndex = 0;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(149, 215);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 35);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CC#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Exp Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Amount";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(164, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 7;
            // 
            // ccBox
            // 
            this.ccBox.Location = new System.Drawing.Point(164, 46);
            this.ccBox.Name = "ccBox";
            this.ccBox.Size = new System.Drawing.Size(100, 22);
            this.ccBox.TabIndex = 8;
            // 
            // ExpBox
            // 
            this.ExpBox.Location = new System.Drawing.Point(164, 81);
            this.ExpBox.Name = "ExpBox";
            this.ExpBox.Size = new System.Drawing.Size(100, 22);
            this.ExpBox.TabIndex = 9;
            // 
            // ZipBox
            // 
            this.ZipBox.Location = new System.Drawing.Point(164, 119);
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(100, 22);
            this.ZipBox.TabIndex = 10;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(164, 158);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 22);
            this.amountBox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.credit_debit;
            this.pictureBox1.Location = new System.Drawing.Point(14, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fee";
            // 
            // feeBox
            // 
            this.feeBox.Location = new System.Drawing.Point(344, 8);
            this.feeBox.Name = "feeBox";
            this.feeBox.Size = new System.Drawing.Size(100, 22);
            this.feeBox.TabIndex = 14;
            this.feeBox.TextChanged += new System.EventHandler(this.feeBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.feeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.ZipBox);
            this.Controls.Add(this.ExpBox);
            this.Controls.Add(this.ccBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyButton);
            this.Name = "Form1";
            this.Text = "Credit Card Info Stealer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox ccBox;
        private System.Windows.Forms.TextBox ExpBox;
        private System.Windows.Forms.TextBox ZipBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox feeBox;
    }
}

