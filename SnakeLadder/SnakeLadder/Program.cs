﻿using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder program");
            StartPosition Start = new StartPosition();
            Console.WriteLine("Enter 1 to roll die");
            Console.WriteLine("Enter 2 to CheckOptions");
            Console.WriteLine("Enter 3 to run program till win position");
            Console.WriteLine("Enter 4 to run program till exact win position");
           
            int result = Convert.ToInt32(Console.ReadLine());
            switch(result)
            {
                case 1:
                    RollDie roll = new RollDie();
                    int newValue = roll.RollDieResult();
                    Console.WriteLine("New die value is :" + newValue);
                    break;
                case 2:

                    CheckOptions newresult = new CheckOptions();
                    break;
                case 3:
                    TillWinPosition final = new TillWinPosition();
                    break;
                case 4:
                    TillExactWinPosition finalwin = new TillExactWinPosition();
                    break;

                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }


        }
    }
}
