namespace Pong_Arcade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Yellow;
            this.player.Location = new System.Drawing.Point(12, 186);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 130);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(435, 240);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.Fuchsia;
            this.cpu.Location = new System.Drawing.Point(887, 186);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(30, 130);
            this.cpu.TabIndex = 2;
            this.cpu.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.Lime;
            this.playerScore.Location = new System.Drawing.Point(105, 9);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(38, 25);
            this.playerScore.TabIndex = 3;
            this.playerScore.Text = "00";
            // 
            // cpuScore
            // 
            this.cpuScore.AutoSize = true;
            this.cpuScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScore.ForeColor = System.Drawing.Color.Red;
            this.cpuScore.Location = new System.Drawing.Point(735, 9);
            this.cpuScore.Name = "cpuScore";
            this.cpuScore.Size = new System.Drawing.Size(38, 25);
            this.cpuScore.TabIndex = 4;
            this.cpuScore.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(929, 576);
            this.Controls.Add(this.cpuScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuScore;
    }
}

