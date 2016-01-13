using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduku
{
    public class SetUserInputs
    {
        List<string> numberWords;

        public SetUserInputs()
        {
            numberWords = new List<string>();
        }

        public int SetCube()
        {
            Console.WriteLine("Enter a perfect cube number for soduku");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public List<string> SetNumberOptions(int amount)
        {
            int counter = 0;
            while (counter < amount)
            {
                Console.WriteLine("Enter a word/Item for the {0} position. ", counter);
                string eachitem = Console.ReadLine();
                numberWords.Add(eachitem);
                counter++;
            }
            return numberWords;
        }
    }
}
