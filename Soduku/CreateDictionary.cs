using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduku
{
    class CreateDictionary
    {
        Random random;

        public CreateDictionary()
        {
            random = new Random();
        }

        public List<int> GenerateLine(int amount, double sqrt)
        {
            List<int> eachLine = new List<int>();
            while (eachLine.Count < amount)
            {
                int nextNumber = RandomNumber(amount + 1);
                if (!eachLine.Contains(nextNumber))
                {
                    eachLine.Add(nextNumber);
                }
            }
            return eachLine;
        }

        public int RandomNumber(int amount)
        {
            int nextNumber = random.Next(1, amount);
            return nextNumber;
        }
    }
}
