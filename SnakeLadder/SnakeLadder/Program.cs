using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder program");
            StartPosition Start = new StartPosition();
            Console.WriteLine("Enter 1 to roll die");
            int result = Convert.ToInt32(Console.ReadLine());
            switch(result)
            {
                case 1:
                    RollDie roll = new RollDie();
                    int newValue = roll.RollDieResult();
                    Console.WriteLine("New die value is :" + newValue);
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }


        }
    }
}
