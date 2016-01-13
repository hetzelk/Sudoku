using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodukuLibrary
{
    public class RandomNumber
    {
        Random random;

        public RandomNumber()
        {
            random = new Random();
        }

        public int getNewRandom()
        {
            int number = random.Next(1, 5);
            return number;
        }
    }
}
