using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class TillWinPosition
    {
        public TillWinPosition()
        {



            int newPosition = 0;
            Console.WriteLine("Your new Position is " + newPosition);
            while (newPosition < 100)
            {
                
                RollDie roll = new RollDie();
                int newValue = roll.RollDieResult();
                Console.WriteLine("The new Die Value is:" + newValue);
                Random random = new Random();
                int option = random.Next(1, 4);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("no play");
                        break;
                    case 2:
                        Console.WriteLine("you got a ladder");
                        newPosition = newPosition + newValue;
                        if (newPosition > 100)
                        {
                            newPosition = newPosition - newValue;
                            Console.WriteLine("your new position is:" + newPosition);

                        }
                        else
                        {
                            Console.WriteLine("your new position is:" + newPosition);
                        }
                        break;
                    case 3:
                        Console.WriteLine("you got a snake");
                        newPosition = newPosition - newValue;
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
            





        }
    }
    }
