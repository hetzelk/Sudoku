using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduku
{
    public class Display
    {
        new Dictionary<int, List<int>> layout;

        public Display()
        {
            layout = new Dictionary<int, List<int>>();
        }

        public void DisplaySoduku(Dictionary<int, List<int>> sodukuLayout, double sqrt)
        {
            layout = sodukuLayout;
            double total = sqrt * sqrt;
            int paircounter = 0;

            string dahsedline = string.Empty;
            int stringcounter = 0;
            while (stringcounter < sodukuLayout.Count)
            {
                dahsedline += "---";
                stringcounter++;
            }

            foreach (KeyValuePair<int, List<int>> pair in layout)
            {
                string itemString = string.Empty;
                double count = 0;
                foreach (int item in pair.Value)
                {
                    string each = String.Format("{0} ", item);
                    if (count % sqrt == 0)
                    {
                        itemString += "| ";
                    }
                    itemString += each;
                    if (count == total - 1)
                    {
                        itemString += "|";
                    }
                    
                    count++;
                }
                Console.WriteLine(itemString);
                paircounter++;

                if (paircounter % sqrt == 0)
                {
                    Console.WriteLine(dahsedline);
                }
                
            }
            Console.Read();
        }
    }
}
