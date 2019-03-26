namespace Arcade_Machine
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pongStart = new System.Windows.Forms.Button();
            this.SnakeStart = new System.Windows.Forms.Button();
            this.ShipStart = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(65, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "RETRO ARCADE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Arcade_Machine.Properties.Resources.Pong;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(65, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Arcade_Machine.Properties.Resources.Snake;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(315, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Arcade_Machine.Properties.Resources.battleship;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(197, 396);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pongStart
            // 
            this.pongStart.Enabled = false;
            this.pongStart.Location = new System.Drawing.Point(132, 356);
            this.pongStart.Name = "pongStart";
            this.pongStart.Size = new System.Drawing.Size(75, 23);
            this.pongStart.TabIndex = 4;
            this.pongStart.Text = "START";
            this.pongStart.UseVisualStyleBackColor = true;
            this.pongStart.Click += new System.EventHandler(this.pongStart_Click);
            // 
            // SnakeStart
            // 
            this.SnakeStart.Enabled = false;
            this.SnakeStart.Location = new System.Drawing.Point(381, 356);
            this.SnakeStart.Name = "SnakeStart";
            this.SnakeStart.Size = new System.Drawing.Size(75, 23);
            this.SnakeStart.TabIndex = 5;
            this.SnakeStart.Text = "START";
            this.SnakeStart.UseVisualStyleBackColor = true;
            this.SnakeStart.Click += new System.EventHandler(this.SnakeStart_Click);
            // 
            // ShipStart
            // 
            this.ShipStart.Enabled = false;
            this.ShipStart.Location = new System.Drawing.Point(260, 602);
            this.ShipStart.Name = "ShipStart";
            this.ShipStart.Size = new System.Drawing.Size(75, 23);
            this.ShipStart.TabIndex = 6;
            this.ShipStart.Text = "START";
            this.ShipStart.UseVisualStyleBackColor = true;
            this.ShipStart.Click += new System.EventHandler(this.ShipStart_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Yellow;
            this.coin.ForeColor = System.Drawing.Color.Magenta;
            this.coin.Location = new System.Drawing.Point(381, 728);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(111, 30);
            this.coin.TabIndex = 7;
            this.coin.Text = "I N S E R T  C O I N";
            this.coin.UseVisualStyleBackColor = false;
            this.coin.Click += new System.EventHandler(this.coin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arcade_Machine.Properties.Resources.arcade_machine_template_by_psychoticbob;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.ShipStart);
            this.Controls.Add(this.SnakeStart);
            this.Controls.Add(this.pongStart);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button pongStart;
        private System.Windows.Forms.Button SnakeStart;
        private System.Windows.Forms.Button ShipStart;
        private System.Windows.Forms.Button coin;
    }
}

