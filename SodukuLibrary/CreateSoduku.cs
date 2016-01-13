using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodukuLibrary
{
    class CreateSoduku
    {/*
        public void nextMain()
        {
            setCube();
            List<string> genericitemlist = setNumberOptions();
            List<int> wholelist = finalchecker();

            Display display = new Display();
            List<string> changedlist = changeCharacters(wholelist, genericitemlist);
            display.displayExample(changedlist);
            Console.Read();
        }

        public List<string> changeCharacters(List<int> wholelist, List<string> genericitemlist)
        {
            List<string> finallist = new List<string> { };

            foreach (int item in wholelist)
            {
                if (item == 1)
                {
                    finallist.Add(genericitemlist[0]);
                }

                if (item == 2)
                {
                    finallist.Add(genericitemlist[1]);
                }

                if (item == 3)
                {
                    finallist.Add(genericitemlist[2]);
                }

                if (item == 4)
                {
                    finallist.Add(genericitemlist[3]);
                }
            }

            return finallist;
        }

        public void setCube()
        {
            Numbers cube = new Numbers();
            Console.WriteLine("How many rows/columns would you like to test? 4, 9, 16, 25, etc-(must be a perfect square) \n(this number technically doesn't matter, it's hardcoded)");
            string cubeword = Console.ReadLine();//this code would matter if I could use a property properly.
            while (cubeword == "")
            {
                Console.WriteLine("Please enter a number(although it doesn't matter)");
                cubeword = Console.ReadLine();
            }
            int cubeint = Convert.ToInt32(cubeword);
            cube.getCube(cubeint);
        }

        public List<string> setNumberOptions()
        {
            Console.WriteLine("Would you like to use something other than numbers? Just hit enter for no. Type anything for yes.");
            string choiceword = Console.ReadLine();
            if (choiceword != "")
            {
                Program program = new Program();
                List<string> visualitems = program.getObjectChoice();
                return visualitems;
            }
            else
            {
                List<string> visualitems = new List<string> { "1", "2", "3", "4" };
                return visualitems;
            }
        }

        public List<int> listCubes()
        {
            Layout lay = new Layout();
            List<int> numberslist = lay.createList();
            return numberslist;
        }

        public List<string> getObjectChoice()
        {
            List<string> listofpositions = new List<string> { };
            Numbers numbers = new Numbers();
            int eachcube = numbers.cubeint;
            int i = 0;
            while (i <= eachcube - 1)
            {
                i++;
                Console.WriteLine(String.Format("Select/Type what to use for the {0} position.", i));
                string item = Console.ReadLine();
                listofpositions.Add(item);
            }
            return listofpositions;
        }

        public List<int> checkTestSquare()
        {
            Numbers cube = new Numbers();
            int eachcube = cube.cubeint;
            int i = 0;
            Check check = new Check();
            List<int> numberlist = new List<int> { };
            List<int> wholesquarelist = new List<int> { };
            while (i <= eachcube)
            {
                i++;
                bool checkrow = false;
                while (checkrow == false)
                {
                    numberlist = listCubes();
                    checkrow = check.checkRow(numberlist);
                }

                int counter = 0;//the only purpose for this is a time delay. I couldn't figure out how to make the Random work correctly, so I added a time so that it could reset.
                while (counter <= 5000000)
                { counter++; }

                numberlist.Remove(numberlist[4]);
                foreach (int correctnumber in numberlist)
                {
                    wholesquarelist.Add(correctnumber);
                    checkrow = false;
                }
                checkrow = false;
            }
            return wholesquarelist;
        }

        public List<int> finalchecker()
        {
            List<int> wholelist = checkTestSquare();

            Check check = new Check();
            bool checkcolumns = check.checkColumns(wholelist);
            bool checksquares = check.checkSquares(wholelist);

            if (checkcolumns == false)
            {
                finalchecker();
            }

            //this next if statement will check to see if the squares have 4 different numbers, but if that fails, then it restarts over and goes through the same checking process. So if you enable this, it will most likely run for 5+ mins, if not infinitely.
            /*if (checksquares == false)
            {
                finalchecker();
            }

            return wholelist;
        }
    */}
}
