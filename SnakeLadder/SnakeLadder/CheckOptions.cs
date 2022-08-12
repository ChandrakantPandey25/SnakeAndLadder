using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class CheckOptions
    {
        public CheckOptions()
        {


            RollDie roll = new RollDie();
            int newValue = roll.RollDieResult();
            Console.WriteLine("The new Die Value is:" + newValue);
            Random random = new Random();
            int option = random.Next(1, 4);
            switch (option)
            {

                case 1:
                    Console.WriteLine("No play");

                    break;
                case 2:
                    Console.WriteLine("you got a Ladder");




                    int newPosition = 0 + newValue;
                    Console.WriteLine("Your new Position is " + newPosition);

                    break;
                case 3:
                    Console.WriteLine("you got a Snake");




                    int newPositionOne = 0 - newValue;

                    if (newPositionOne <= 0)
                    {
                        Console.WriteLine("your new position is :" + 0);
                    }
                    else
                    {
                        Console.WriteLine("Your new Position is " + newPositionOne);
                    }

                    break;


            }

        }
    }
}
