using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class TwoPlayer
    {
        public TwoPlayer()
        {
            int firstPlayerPosition = 0;
            int secondPlayerPosition = 1;
            int numTimeFirstPlayerDiceRolled = 0;
            int numTimeSecondPlayerDiceRolled = 0;



            Random random = new Random();
            int option = random.Next(0, 2);
            switch (option)
            {
                case 0:
                    Console.WriteLine("First player will start the game");
                    while (firstPlayerPosition < 100 && secondPlayerPosition < 100)
                    {
                        RollDie roll = new RollDie();
                        int newValue = roll.RollDieResult();




                        Random random1 = new Random();
                        int option1 = random1.Next(1, 4);

                        switch (option1)
                        {
                            case 1:
                                Console.WriteLine("no play");
                                break;
                            case 2:
                                Console.WriteLine("you got a ladder");
                                firstPlayerPosition = firstPlayerPosition + newValue;
                                if (firstPlayerPosition > 100)
                                {
                                    firstPlayerPosition = firstPlayerPosition - newValue;
                                    Console.WriteLine("your new position is:" + firstPlayerPosition);

                                }
                                else
                                {
                                    Console.WriteLine("your new position is:" + firstPlayerPosition);
                                }
                                int option2 = 2;
                                while (option2 == 2)
                                {
                                    RollDie roll1 = new RollDie();
                                    int newValue1 = roll1.RollDieResult();
                                    Random random2 = new Random();
                                    option2 = random2.Next(1, 4);
                                    Console.WriteLine("you got a ladder");
                                    firstPlayerPosition = firstPlayerPosition + newValue1;
                                    if (firstPlayerPosition > 100)
                                    {
                                        firstPlayerPosition = firstPlayerPosition - newValue1;
                                        Console.WriteLine("your new position is:" + firstPlayerPosition);

                                    }
                                    else
                                    {
                                        Console.WriteLine("your new position is:" + firstPlayerPosition);
                                    }
                                }


                                break;
                            case 3:
                                Console.WriteLine("you got a snake");
                                firstPlayerPosition = firstPlayerPosition - newValue;
                                if (firstPlayerPosition < 0)
                                {
                                    firstPlayerPosition = 0;
                                    Console.WriteLine("your new position is:" + firstPlayerPosition);
                                }
                                else
                                {
                                    Console.WriteLine("your new position is:" + firstPlayerPosition);
                                }
                                break;
                                numTimeFirstPlayerDiceRolled++;
                                

                                Console.WriteLine("Turn of Second Player");

                                RollDie roll2 = new RollDie();
                                int newValue2 = roll2.RollDieResult();




                                Random random3 = new Random();
                                int option3 = random3.Next(1, 4);

                                switch (option3)
                                {
                                    case 1:
                                        Console.WriteLine("no play");
                                        break;
                                    case 2:
                                        Console.WriteLine("you got a ladder");
                                        secondPlayerPosition = secondPlayerPosition + newValue2;
                                        if (secondPlayerPosition > 100)
                                        {
                                            secondPlayerPosition = secondPlayerPosition - newValue2;
                                            Console.WriteLine("your new position is:" + secondPlayerPosition);

                                        }
                                        else
                                        {
                                            Console.WriteLine("your new position is:" + secondPlayerPosition);
                                        }
                                        int option4 = 2;
                                        while (option4 == 2)
                                        {
                                            RollDie roll1 = new RollDie();
                                            int newValue3 = roll1.RollDieResult();
                                            Random random2 = new Random();
                                            option4 = random2.Next(1, 4);
                                            Console.WriteLine("you got a ladder");
                                            secondPlayerPosition = secondPlayerPosition + newValue3;
                                            if (secondPlayerPosition > 100)
                                            {
                                                secondPlayerPosition = secondPlayerPosition - newValue3;
                                                Console.WriteLine("your new position is:" + secondPlayerPosition);

                                            }
                                            else
                                            {
                                                Console.WriteLine("your new position is:" + secondPlayerPosition);
                                            }
                                        }


                                        break;
                                    case 3:
                                        Console.WriteLine("you got a snake");
                                        secondPlayerPosition = secondPlayerPosition - newValue2;
                                        if (secondPlayerPosition < 0)
                                        {
                                            secondPlayerPosition = 0;
                                            Console.WriteLine("your new position is:" + secondPlayerPosition);
                                        }
                                        else
                                        {
                                            Console.WriteLine("your new position is:" + secondPlayerPosition);
                                        }
                                        break;

                                        numTimeSecondPlayerDiceRolled++;
                                }


                                
                        
                        
                        }
             
                    }
                    if (numTimeFirstPlayerDiceRolled < numTimeSecondPlayerDiceRolled)
                    {
                        Console.WriteLine("First Player has won the game");
                    }
                    else
                    {
                        Console.WriteLine("Second Player has won the game");
                    }
                    break;

                    case1:
                    Console.WriteLine("Second player will start the game");
                    while (firstPlayerPosition < 100 && secondPlayerPosition <  100)
                    {
                        RollDie roll = new RollDie();
                        int newValue = roll.RollDieResult();




                        Random random1 = new Random();
                        int option1 = random1.Next(1, 4);

                        switch (option1)
                        {
                            case 1:
                                Console.WriteLine("no play");
                                break;
                            case 2:
                                Console.WriteLine("you got a ladder");
                                secondPlayerPosition = secondPlayerPosition + newValue;
                                if (secondPlayerPosition > 100)
                                {
                                    secondPlayerPosition = secondPlayerPosition - newValue;
                                    Console.WriteLine("your new position is:" + secondPlayerPosition);

                                }
                                else
                                {
                                    Console.WriteLine("your new position is:" + secondPlayerPosition);
                                }
                                int option2 = 2;
                                while (option2 == 2)
                                {
                                    RollDie roll1 = new RollDie();
                                    int newValue1 = roll1.RollDieResult();
                                    Random random2 = new Random();
                                    option2 = random2.Next(1, 4);
                                    Console.WriteLine("you got a ladder");
                                    secondPlayerPosition = secondPlayerPosition + newValue1;
                                    if (secondPlayerPosition > 100)
                                    {
                                        secondPlayerPosition = secondPlayerPosition - newValue1;
                                        Console.WriteLine("your new position is:" + secondPlayerPosition);

                                    }
                                    else
                                    {
                                        Console.WriteLine("your new position is:" + secondPlayerPosition);
                                    }
                                }


                                break;
                            case 3:
                                Console.WriteLine("you got a snake");
                                secondPlayerPosition = secondPlayerPosition - newValue;
                                if (secondPlayerPosition < 0)
                                {
                                    secondPlayerPosition = 0;
                                    Console.WriteLine("your new position is:" + secondPlayerPosition);
                                }
                                else
                                {
                                    Console.WriteLine("your new position is:" + secondPlayerPosition);
                                }
                                break;
                                numTimeSecondPlayerDiceRolled++;


                                Console.WriteLine("Turn of First Player");

                                RollDie roll2 = new RollDie();
                                int newValue2 = roll2.RollDieResult();




                                Random random3 = new Random();
                                int option3 = random3.Next(1, 4);

                                switch (option3)
                                {
                                    case 1:
                                        Console.WriteLine("no play");
                                        break;
                                    case 2:
                                        Console.WriteLine("you got a ladder");
                                        firstPlayerPosition = firstPlayerPosition + newValue2;
                                        if (firstPlayerPosition > 100)
                                        {
                                            firstPlayerPosition = firstPlayerPosition - newValue2;
                                            Console.WriteLine("your new position is:" + firstPlayerPosition);

                                        }
                                        else
                                        {
                                            Console.WriteLine("your new position is:" + firstPlayerPosition);
                                        }
                                        int option4 = 2;
                                        while (option4 == 2)
                                        {
                                            RollDie roll1 = new RollDie();
                                            int newValue3 = roll1.RollDieResult();
                                            Random random2 = new Random();
                                            option4 = random2.Next(1, 4);
                                            Console.WriteLine("you got a ladder");
                                            firstPlayerPosition = firstPlayerPosition + newValue3;
                                            if (firstPlayerPosition > 100)
                                            {
                                                firstPlayerPosition = firstPlayerPosition - newValue3;
                                                Console.WriteLine("your new position is:" + firstPlayerPosition);

                                            }
                                            else
                                            {
                                                Console.WriteLine("your new position is:" + firstPlayerPosition);
                                            }
                                        }


                                        break;
                                    case 3:
                                        Console.WriteLine("you got a snake");
                                        firstPlayerPosition = firstPlayerPosition - newValue2;
                                        if (firstPlayerPosition < 0)
                                        {
                                            firstPlayerPosition = 0;
                                            Console.WriteLine("your new position is:" + firstPlayerPosition);
                                        }
                                        else
                                        {
                                            Console.WriteLine("your new position is:" + firstPlayerPosition);
                                        }
                                        break;

                                        numTimeFirstPlayerDiceRolled++;
                                }





                        }

                    
      
                    }
                    if(numTimeFirstPlayerDiceRolled<numTimeSecondPlayerDiceRolled)
                    {
                        Console.WriteLine("First Player has won the game");
                    }
                    else
                    {
                        Console.WriteLine("Second Player has won the game");
                    }
       break;


            }
        }
    }
}
