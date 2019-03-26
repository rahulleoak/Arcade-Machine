using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        // starts a list array for circle class

        private Circle food = new Circle();
        // creates the food (point system) via Circle class

        public Form1()
        {
            InitializeComponent();

            new Settings();

            gameTimer.Interval = 1000; //Timer to work with Settings Speed
            gameTimer.Tick += UpdateScreen; // Reset upon elapsed timer
            gameTimer.Start(); 

            startGame();//Start the game


        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.Gameover == true)
            {
                if (Input.KeyPress(Keys.Enter))
                {
                    startGame();
                }
            }

            else
            {
                if (Input.KeyPress(Keys.Right) && Settings.direction != Directions.Left)
                {
                    Settings.direction = Directions.Right;
                }
                else if (Input.KeyPress(Keys.Left) && Settings.direction != Directions.Right)
                {
                    Settings.direction = Directions.Left;
                }
                else if (Input.KeyPress(Keys.Down) && Settings.direction != Directions.Up)
                {
                    Settings.direction = Directions.Down;
                }
                else if (Input.KeyPress(Keys.Up) && Settings.direction != Directions.Down)
                {
                    Settings.direction = Directions.Up;
                }

                movePlayer(); //start to move the player w.r.t the direction
            }

            pbCanvas.Invalidate();

        }

        private void movePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Directions.Right:
                            Snake[i].X++;
                            break;
                        case Directions.Left:
                            Snake[i].X--;
                            break;
                        case Directions.Up:
                            Snake[i].Y--;
                            break;
                        case Directions.Down:
                            Snake[i].Y++;
                            break;
                    }

                    //snake shouldnt be able to leave the game area
                    int maxYpos = pbCanvas.Size.Height / Settings.Height;
                    int maxXpos = pbCanvas.Size.Width / Settings.Width;

                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X > maxXpos || Snake[i].Y > maxYpos)
                    {
                        die();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            die();
                        }
                    }

                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        eat();
                    }

                }

                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }


        private void keyisdown(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, true);

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, false);
        }

        private void updateGraphic(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (Settings.Gameover == false)
            {
                Brush SnakeColor;

                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        SnakeColor = Brushes.Black;
                    }

                    else
                    {
                        SnakeColor = Brushes.Green;
                    }

                    //drawing snake
                    canvas.FillEllipse(SnakeColor, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width, Settings.Height));

                    //drawing food
                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }

            else
            {
                //for when Game is over

                string gameOver = "Game Over \n" + "Final Score: " + Settings.Score + "\nPress Enter to RESTART";
                label3.Text = gameOver;
                label3.Visible = true;
            }
        }

        private void startGame()
        {
            label3.Visible = false;
            new Settings();
            Snake.Clear();
            Circle Head = new Circle { X = 10, Y = 5 };
            Snake.Add(Head);

            label2.Text = Settings.Score.ToString();
            generateFood();

        }

        private void generateFood()
        {
            int maxXpos = pbCanvas.Size.Width / Settings.Width;
            int maxYpos = pbCanvas.Size.Height / Settings.Height;

            Random rnd = new Random();
            food = new Circle{ X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };
        }

        private void eat()
        {
            Circle body = new Circle { X = Snake[Snake.Count - 1].X, Y = Snake[Snake.Count - 1].Y };
            Snake.Add(body);
            Settings.Score += Settings.Points;
            label2.Text = Settings.Score.ToString();
            generateFood();
        }

        private void die()
        {
            Settings.Gameover = true;
        }
    }
}
