using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong_Arcade
{
    public partial class Form1 : Form
    {
        bool goup;// detect up-pos
        bool godown;//detect down-pos
        int speed = 5; //general speed of ball
        int ballx = 5; //horizontal speed of ball
        int bally = 5;// vertical speed of ball
        int score = 0;
        int cpuPoint = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                //Up-Key activates bool up
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                //Down-Key activates bool down
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
                //Up-Key deactivates bool up
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = false;
                //Down-Key deactivates bool down
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            playerScore.Text = "" + score;
            cpuScore.Text = "" + cpuPoint;

            ball.Top -= bally;
            ball.Left -= ballx;

            cpu.Top += speed;

            if (score < 5)
            {
                if (cpu.Top < 0 || cpu.Top > 455)
                {
                    speed = -speed;
                }
            }

            else
            {
                cpu.Top = ball.Top + 30;
            }

            if (ball.Left < 0)
            {
                ball.Left = 433;
                ballx = -ballx;
                ballx -= 2;
                cpuPoint++;
            }

            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx += 2;
                score++;
            }

            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                bally = -bally;
            }

            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballx = -ballx;
            }

            if (goup == true && player.Top > 0)
            {
                player.Top -= 8;
            }

            if (godown == true && player.Top < 455)
            {
                player.Top += 8;
            }

            if (score > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("Player WINS");
                this.Close();
            }

            if (cpuPoint > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("CPU WINS");
                this.Close();
            }

        }
    }
}
