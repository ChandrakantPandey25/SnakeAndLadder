using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class RollDie
    {
        public int RollDieResult()
        {

            Random Roll = new Random();
            int dieResult = Roll.Next(1, 7);

            return dieResult;

        }
    }
}
