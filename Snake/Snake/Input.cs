using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;// Obtain Class:Hashtable
using System.Windows.Forms; //Obtain Class:Keys

namespace Snake
{
    class Input
    {
        private static Hashtable keyTable = new Hashtable();

        public static bool KeyPress(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
                //indicates Hashtable is empty
            }

            return (bool)keyTable[key];
            //indicates Hashtable is not empty;
        }

        public static void changeState(Keys key, bool State)
        {
            keyTable[key] = State;
            //keystate is changed and hence player state also
        }
            
    }
}
