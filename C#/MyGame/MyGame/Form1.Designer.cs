namespace MyGame
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groundBox = new System.Windows.Forms.PictureBox();
            this.player1Box = new System.Windows.Forms.PictureBox();
            this.player2Box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Box)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(213, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyGame.Properties.Resources.brixel;
            this.pictureBox1.Location = new System.Drawing.Point(635, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groundBox
            // 
            this.groundBox.Image = global::MyGame.Properties.Resources.green;
            this.groundBox.Location = new System.Drawing.Point(-5, 402);
            this.groundBox.Name = "groundBox";
            this.groundBox.Size = new System.Drawing.Size(809, 49);
            this.groundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundBox.TabIndex = 3;
            this.groundBox.TabStop = false;
            // 
            // player1Box
            // 
            this.player1Box.Image = global::MyGame.Properties.Resources.avatarCropped;
            this.player1Box.Location = new System.Drawing.Point(131, 100);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(34, 50);
            this.player1Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1Box.TabIndex = 0;
            this.player1Box.TabStop = false;
            // 
            // player2Box
            // 
            this.player2Box.Image = global::MyGame.Properties.Resources.avatar2;
            this.player2Box.Location = new System.Drawing.Point(375, 125);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(34, 50);
            this.player2Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2Box.TabIndex = 2;
            this.player2Box.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groundBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.player1Box);
            this.Controls.Add(this.player2Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player1Box;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player2Box;
        private System.Windows.Forms.PictureBox groundBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

