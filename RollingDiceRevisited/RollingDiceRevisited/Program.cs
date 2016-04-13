using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            var RollAgain = false;
            do
            {
                Console.Clear();
                var Dice = 0;
                var Roll = 0;
                var Iteration1 = new List<int>();
                var Iteration2 = new List<int>();

                while (Dice < 1)
                {
                    Console.WriteLine("How many dice will be used?");
                    Dice = Convert.ToInt32(Console.ReadLine());
                };

                while (Roll < 1)
                {
                    Console.WriteLine("How many rolls will be completed?");
                    Roll = Convert.ToInt32(Console.ReadLine());
                };

                Iteration1 = Rolling.ListOfRollValues(Dice, Roll);
                Iteration2 = Rolling.ListOfRollValues(Dice, Roll);

                var Group1 = Iteration1.GroupBy(value => value);
                var Group2 = Iteration2.GroupBy(value => value);
                var Except1 = Iteration1.Except(Iteration2);
                var Except2 = Iteration2.Except(Iteration1);

                Output.UniqueValues(1, Except1, Group1);
                Output.UniqueValues(2, Except2, Group2);
                Output.SharedValues(Group1, Group2);
                Console.WriteLine("");
                Output.HighestRoll(1, Iteration1);
                Output.HighestRoll(2, Iteration2);
                Console.WriteLine("");
                Output.MostRolled(1, Group1);
                Output.MostRolled(2, Group2);
                Console.WriteLine("");
                Output.AverageRoll(1, Iteration1);
                Output.AverageRoll(2, Iteration2);

                Console.Write("\nRoll Again? [Y/N]");
                RollAgain = Console.ReadKey().Key == ConsoleKey.Y;
            } while (RollAgain);
        }
    }
}