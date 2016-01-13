using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodukuLibrary
{
    public class Layout
    {
       
        public List<int> createList()
        {
            List<int> numbers = new List<int> { };
            RandomNumber rand = new RandomNumber();
            int i = 0;
            Numbers cube = new Numbers();
            int eachcube = cube.cubeint;
            while (i <= eachcube)
            {
                i++;
                int number = rand.getNewRandom();
                numbers.Add(number);
            }
            return numbers;
        }
    }
}
