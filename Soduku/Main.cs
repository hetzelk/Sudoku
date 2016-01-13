using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduku
{
    public class Main
    {
        Dictionary<int, List<int>> layout;
        SetUserInputs inputs;
        List<string> numberNames;
        CreateDictionary creator;
        int cubenumber;
        double sqrt;
        Display display;

        public Main()
        {
            layout = new Dictionary<int, List<int>>();
            inputs = new SetUserInputs();
            numberNames = new List<string>();
            creator = new CreateDictionary();
            display = new Display();
        }

        public void RunSoduku()
        {
            cubenumber = inputs.SetCube();
            //numberNames = inputs.SetNumberOptions(cubenumber);
            sqrt = Math.Sqrt(cubenumber);
            AddToDictionary(cubenumber, sqrt);
            display.DisplaySoduku(layout, sqrt);
        }

        public void AddToDictionary(int cubenumber, double sqrt)
        {
            int count = 0;
            while(count < cubenumber)
            {
                List<int> eachLine = creator.GenerateLine(cubenumber, sqrt);
                layout.Add(count, eachLine);
                count++;
            }
        }
    }
}
