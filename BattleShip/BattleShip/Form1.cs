using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace BattleShip
{
    public partial class Form1 : Form
    {
        List<Button> playerPosition;
        List<Button> enemyPosition;
        Random rand  = new Random();

        int totalShips = 3;
        int totalEnemy = 3;
        int rounds = 10;
        int playertotalScore = 0;
        int enemytotalScore = 0;


        public Form1()
        {
            InitializeComponent();

            loadbuttons();
            attackButton.Enabled = false;
            enemylocationList.Text = null;
        }

        private void playerpicksPosition(object sender, EventArgs e)
        {
                if (totalShips > 0)
                {
                    var button = (Button)sender;

                    button.Enabled=false;
                    button.Tag = "playerShip";
                    button.BackColor = System.Drawing.Color.Blue;
                    totalShips--;
                }

                if(totalShips == 0)
                {
                    attackButton.Enabled = true;
                    attackButton.BackColor = System.Drawing.Color.Red;
                    
                    helpText.Top = 30;
                    helpText.Left = 395;
                    helpText.Text = "Pick ATTACK POS via Dropdown";
                }

        }

        private void attackEnemyPosition(object sender, EventArgs e)
        {
            if(enemylocationList.Text!="")
            {
                var attackPos = enemylocationList.Text;
                attackPos = attackPos.ToLower();
                int index = enemyPosition.FindIndex(a => a.Name == attackPos);

                if(enemyPosition[index].Enabled && rounds>0)
                {
                    rounds--;
                    roundsText.Text = "Rounds: "+rounds;

                    if(enemyPosition[index].Tag == "enemyship")
                    {
                        enemyPosition[index].Enabled = false;
                        enemyPosition[index].BackgroundImage = Properties.Resources.fireIcon;
                        enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue;

                        playertotalScore++;
                        playerScore.Text = "" +playertotalScore;
                        enemyplayTimer.Start();
                    }

                    else
                    {
                        enemyPosition[index].Enabled = false;
                        enemyPosition[index].BackgroundImage = Properties.Resources.missIcon;
                        enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue;

                        enemyplayTimer.Start();
                    }

                }
            }
            
            else
            {
                MessageBox.Show("FIRE AT ENEMY VIA DROPDOWN MENU");
            }
            
        }

        private void enemyattackPlayer(object sender, EventArgs e)
        {
            if(playerPosition.Count > 0 &&  rounds > 0) 
            {
                rounds--;
                roundsText.Text = "Rounds: " + rounds;

                int index = rand.Next(playerPosition.Count);

                if(playerPosition[index].Tag == "playerShip")
                {
                    playerPosition[index].BackgroundImage= Properties.Resources.fireIcon;

                    enemyMoves.Text = "" + playerPosition[index].Text;
                    playerPosition[index].Enabled = false;
                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                    playerPosition.RemoveAt(index);

                    enemytotalScore++;
                    enemyScore.Text = "" + enemytotalScore;
                    enemyplayTimer.Stop();
                }

                else
                {
                    playerPosition[index].BackgroundImage= Properties.Resources.missIcon;

                    enemyMoves.Text = "" + playerPosition[index].Text;
                    playerPosition[index].Enabled = false;
                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                    playerPosition.RemoveAt(index);

                    enemyplayTimer.Stop();
                }
            }

            if(rounds < 1 || playertotalScore > 2 || enemytotalScore > 2)
            {
                if(playertotalScore > enemytotalScore)
                {
                    MessageBox.Show("WE GOT EM!", "VICTORY");
                }

                if (playertotalScore == enemytotalScore)
                {
                    MessageBox.Show("NO WINNERS THIS TIME");
                }

                if (playertotalScore < enemytotalScore)
                {
                    MessageBox.Show("LETS GET THEM NEXT TIME", "DEFEAT");
                }
            }
        }

        private void enemypositionPicker_Tick(object sender, EventArgs e)
        {
            int index = rand.Next(enemyPosition.Count);

            if(enemyPosition[index].Enabled == true && enemyPosition[index].Tag == null)
            {
                enemyPosition[index].Tag = "enemyship";
                totalEnemy--;

                Debug.WriteLine("Enemy Pos: " + enemyPosition[index].Tag);
            }
            
            else
            {
                index = rand.Next(enemyPosition.Count);
            }

            if(totalEnemy < 1)
            {
                enemypositionPicker.Stop();
            }
        }

        private void loadbuttons()
        {
            playerPosition = new List<Button> {w1,w2,w3,w4,x1,x2,x3,x4,y1,y2,y3,y4,z1,z2,z3,z4};
            enemyPosition = new List<Button> {a1,a2,a3,a4,b1,b2,b3,b4,c1,c2,c3,c4,d1,d1,d3,d4};

            for (int i = 0; i< enemyPosition.Count; i++)
            {
                enemyPosition[i].Tag = null;
                enemylocationList.Items.Add(enemyPosition[i].Text);
            }
        }
    }
}
