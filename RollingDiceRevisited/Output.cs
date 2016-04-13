using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Output
    {
        public static void UniqueValues(int N, IEnumerable<int> Except, IEnumerable<IGrouping<int, int>> Group)
        {
            Console.WriteLine("\nUnique values in iteration {0}: ", N);
            Console.WriteLine("\n Value\tOccurences");
            Console.WriteLine(" =====\t==========");
            Except.ToList().ForEach(e => 
                { Group.ToList().ForEach(g =>
                { if (e == g.Key) { Console.WriteLine(" {0}\t{1}", g.Key, g.Count()); } }); });
        }

        public static void SharedValues(IEnumerable<IGrouping<int, int>> Group1, IEnumerable<IGrouping<int, int>> Group2)
        {
            Console.WriteLine("\nShared values between both iterations:");
            Console.WriteLine("\n Value\tItr 1\tItr 2");
            Console.WriteLine(" =====\t=====\t=====");
            Group1.ToList().ForEach(g1 =>
                { Group1.ToList().ForEach(g2 =>
                { if (g1.Key == g2.Key) { Console.WriteLine(" {0}\t{1}\t{2}", g2.Key, g1.Count(), g2.Count()); } }); });
        }

        public static void HighestRoll(int N, IEnumerable<int> Group)
        {
            var HighestRollValue = 0;
            Group.ToList().ForEach(g =>
                { if (g > HighestRollValue) { HighestRollValue = g; } });
            Console.WriteLine("Iteration {0} Highest Rolled Value: {1}", N, HighestRollValue);
        }

        public static void MostRolled(int N, IEnumerable<IGrouping<int, int>> Group)
        {
            var TimesRolled = 0;
            var Keys = new List<int>();
            Group.ToList().ForEach(g =>
                { if (g.Count() > TimesRolled) { TimesRolled = g.Count(); } });
            Group.ToList().ForEach(g =>
                { if (g.Count() == TimesRolled) { Keys.Add(g.Key); } });
            var Values = String.Join(",", Keys);
            Console.WriteLine("Iteration {0} Most Rolled Value(s): {1} rolled {2} times.", N, Values, TimesRolled);
        }

        public static void AverageRoll(int N, IEnumerable<int> Group)
        {
            string Average = Group.ToList().Average().ToString("F");
            Console.WriteLine("Iteration {0} Average Roll Value: {1}", N, Average);
        }
    }
}