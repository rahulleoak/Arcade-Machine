using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Directions
    {
        //identify as well as classify the various directions of movement
        Left,
        Right,
        Up,
        Down
    };

    class Settings
    {
        public static int Width {get;set;}  // sets width dimension
        public static int Height {get;set;} //sets height dimension
        public static int Speed {get;set;} //sets Speed of movement
        public static int Score {get;set;} //sets Score
        public static int Points { get; set; } //sets Points
        
        public static bool Gameover {get;set;} //used to indicate if game is over or not
        public static Directions direction {get;set;}

        public Settings()
        {
            //assigning value to the variables upon calling settings

            Width = 16;
            Height = 16;
            Speed = 20;
            Score = 0;
            Points = 100;
            Gameover = false;
            direction = Directions.Down;
        }
    }
}
