using System;
using System.Collections.Generic;

namespace RobotCleaner
{
    class Program
    {
        static void Main(string[] args)
        {           
            var comandsCount = Console.ReadLine();
            var currentPosition = Console.ReadLine();
            var robotInstructions = new List<RobotInstruction>();
            for(var i = 0; i < int.Parse(comandsCount); i++)
            {
                robotInstructions.Add(new RobotInstruction(Console.ReadLine()));
            }

            var robotCleaner = new RobotCleaner(int.Parse(currentPosition.Split(' ')[0]), int.Parse(currentPosition.Split(' ')[1]));
            robotCleaner.ExecuteInstructions(robotInstructions);
            Console.WriteLine(robotCleaner.GetCleanedLocationsCount());
        }
    }
}
