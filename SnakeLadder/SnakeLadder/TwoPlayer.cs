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
            int secondPlayerPosition = 0;
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

                        numTimeFirstPlayerDiceRolled++;


                        Random randomOne = new Random();
                        int optionOne = randomOne.Next(1, 4);

                        switch (optionOne)
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
                                int optionTwo = 2;
                                while (optionTwo == 2)
                                {
                                    RollDie rollOne = new RollDie();
                                    int newValueOne = rollOne.RollDieResult();
                                    numTimeFirstPlayerDiceRolled++;
                                    Random randomTwo = new Random();
                                    optionTwo = randomTwo.Next(1, 4);
                                    Console.WriteLine("you got a ladder");
                                    firstPlayerPosition = firstPlayerPosition + newValueOne;
                                    if (firstPlayerPosition > 100)
                                    {
                                        firstPlayerPosition = firstPlayerPosition - newValueOne;
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
                                
                                

                                Console.WriteLine("Turn of Second Player");

                                RollDie rollTwo = new RollDie();
                                int newValueTwo = rollTwo.RollDieResult();
                                numTimeSecondPlayerDiceRolled++;




                                Random randomThree = new Random();
                                int optionThree = randomThree.Next(1, 4);

                                switch (optionThree)
                                {
                                    case 1:
                                        Console.WriteLine("no play");
                                        break;
                                    case 2:
                                        Console.WriteLine("you got a ladder");
                                        secondPlayerPosition = secondPlayerPosition + newValueTwo;
                                        if (secondPlayerPosition > 100)
                                        {
                                            secondPlayerPosition = secondPlayerPosition - newValueTwo;
                                            Console.WriteLine("your new position is:" + secondPlayerPosition);

                                        }
                                        else
                                        {
                                            Console.WriteLine("your new position is:" + secondPlayerPosition);
                                        }
                                        int optionFour = 2;
                                        while (optionFour == 2)
                                        {
                                            RollDie rollThree = new RollDie();
                                            int newValueThree = rollThree.RollDieResult();
                                            numTimeSecondPlayerDiceRolled++;
                                            Random randomFour = new Random();
                                            optionFour = randomFour.Next(1, 4);
                                            Console.WriteLine("you got a ladder");
                                            secondPlayerPosition = secondPlayerPosition + newValueThree;
                                            if (secondPlayerPosition > 100)
                                            {
                                                secondPlayerPosition = secondPlayerPosition - newValueThree;
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
                                        secondPlayerPosition = secondPlayerPosition - newValueTwo;
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

                    case 1:
                    Console.WriteLine("Second player will start the game");
                    while (firstPlayerPosition < 100 && secondPlayerPosition <  100)
                    {
                        RollDie roll = new RollDie();
                        int newValue = roll.RollDieResult();
                        numTimeSecondPlayerDiceRolled++;



                        Random randomOne = new Random();
                        int optionOne = randomOne.Next(1, 4);

                        switch (optionOne)
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
                                int optionTwo = 2;
                                while (optionTwo == 2)
                                {
                                    RollDie rollOne = new RollDie();
                                    int newValueOne = rollOne.RollDieResult();
                                    numTimeSecondPlayerDiceRolled++;
                                    Random randomTwo = new Random();
                                    optionTwo = randomTwo.Next(1, 4);
                                    Console.WriteLine("you got a ladder");
                                    secondPlayerPosition = secondPlayerPosition + newValueOne;
                                    if (secondPlayerPosition > 100)
                                    {
                                        secondPlayerPosition = secondPlayerPosition - newValueOne;
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
                                


                                Console.WriteLine("Turn of First Player");

                                RollDie rollTwo = new RollDie();
                                int newValueTwo = rollTwo.RollDieResult();
                                numTimeFirstPlayerDiceRolled++;



                                Random randomThree = new Random();
                                int optionThree = randomThree.Next(1, 4);

                                switch (optionThree)
                                {
                                    case 1:
                                        Console.WriteLine("no play");
                                        break;
                                    case 2:
                                        Console.WriteLine("you got a ladder");
                                        firstPlayerPosition = firstPlayerPosition + newValueTwo;
                                        if (firstPlayerPosition > 100)
                                        {
                                            firstPlayerPosition = firstPlayerPosition - newValueTwo;
                                            Console.WriteLine("your new position is:" + firstPlayerPosition);

                                        }
                                        else
                                        {
                                            Console.WriteLine("your new position is:" + firstPlayerPosition);
                                        }
                                        int optionFour = 2;
                                        while (optionFour == 2)
                                        {
                                            RollDie rollThree = new RollDie();
                                            int newValueThree = rollThree.RollDieResult();
                                            numTimeFirstPlayerDiceRolled++;
                                            Random randomFour = new Random();
                                            optionFour = randomFour.Next(1, 4);
                                            Console.WriteLine("you got a ladder");
                                            firstPlayerPosition = firstPlayerPosition + newValueThree;
                                            if (firstPlayerPosition > 100)
                                            {
                                                firstPlayerPosition = firstPlayerPosition - newValueThree;
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
                                        firstPlayerPosition = firstPlayerPosition - newValueTwo;
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
