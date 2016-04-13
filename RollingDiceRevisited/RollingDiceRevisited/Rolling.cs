using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Rolling
    {
        private static Random Random = new Random();

        public static List<int> ListOfRollValues(int Dice, int Roll)
        {
            var List = new List<int>();

            for (int i = 0; i < Roll; i++)
            {
                var RollValue = 0;
                for (int j = 0; j < Dice; j++)
                {
                    RollValue = RollValue + Random.Next(1, 7);
                }
                List.Add(RollValue);
            }

            return List;
        }
    }
}