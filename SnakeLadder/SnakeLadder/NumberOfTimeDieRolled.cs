using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class NumberOfTimeDieRolled
    {
        public NumberOfTimeDieRolled()
        {
            int rollTime = 0;
            RollDie roll = new RollDie();
            int newValue = roll.RollDieResult();


            int newPosition = 0 + newValue;
            Console.WriteLine("Your new Position is " + newPosition);
            while (newPosition < 100)
            {
                rollTime++;
                RollDie roll1 = new RollDie();
                int newValue1 = roll1.RollDieResult();
                Console.WriteLine("The new Die Value is:" + newValue1);
                Random random1 = new Random();
                int option1 = random1.Next(1, 4);

                switch (option1)
                {
                    case 1:
                        Console.WriteLine("no play");
                        break;
                    case 2:
                        Console.WriteLine("you got a ladder");
                        newPosition = newPosition + newValue1;
                        if (newPosition > 100)
                        {
                            newPosition = newPosition - newValue1;
                            Console.WriteLine("your new position is:" + newPosition);

                        }
                        else
                        {
                            Console.WriteLine("your new position is:" + newPosition);
                        }
                        break;
                    case 3:
                        Console.WriteLine("you got a snake");
                        newPosition = newPosition - newValue1;
                        if (newPosition < 0)
                        {
                            newPosition = 0;
                            Console.WriteLine("your new position is:" + newPosition);
                        }
                        else
                        {
                            Console.WriteLine("your new position is:" + newPosition);
                        }
                        break;
                }

            }
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("finish point reached");
            Console.WriteLine("Number of times Dice rolled:" + rollTime);





        }
    }
}
