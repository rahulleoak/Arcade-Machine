using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Arcade_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void coin_Click(object sender, EventArgs e)
        {
            coin.Enabled = false;
            SnakeStart.Enabled = true;
            ShipStart.Enabled = true;
            pongStart.Enabled = true;

        }

        private void pongStart_Click(object sender, EventArgs e)
        {
            this.Close();
            Process.Start("C:\\Users\\Rahol\\Documents\\Visual Studio 2010\\Projects\\Pong_Arcade\\Pong_Arcade\\bin\\Debug\\Pong_Arcade.exe");
        }

        private void SnakeStart_Click(object sender, EventArgs e)
        {
            this.Close();
            Process.Start("C:\\Users\\Rahol\\Documents\\Visual Studio 2010\\Projects\\Snake\\Snake\\bin\\Debug\\Snake.exe");
        }

        private void ShipStart_Click(object sender, EventArgs e)
        {
            this.Close();
            Process.Start("C:\\Users\\Rahol\\Documents\\Visual Studio 2010\\Projects\\BattleShip\\BattleShip\\bin\\Debug\\BattleShip.exe");
        }



    }
}
