using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodukuLibrary
{
    public class Check
    {
        public bool checkRow(List<int> row)//horizontal
        {
            if (row[0].Equals(row[1]))
            { return false; }

            if (row[0].Equals(row[2]))
            { return false; }

            if (row[0].Equals(row[3]))
            { return false; }

            if (row[1].Equals(row[2]))
            { return false; }

            if (row[1].Equals(row[3]))
            { return false; }

            if (row[2].Equals(row[3]))
            { return false; }

            else
            { return true; }
        }

        public bool checkColumns(List<int> wholelist)
        {
            if (wholelist[0].Equals(wholelist[4]))
            { return false; }

            if (wholelist[0].Equals(wholelist[8]))
            { return false; }

            if (wholelist[0].Equals(wholelist[12]))
            { return false; }

            
            if (wholelist[1].Equals(wholelist[5]))
            { return false; }

            if (wholelist[1].Equals(wholelist[9]))
            { return false; }

            if (wholelist[1].Equals(wholelist[13]))
            { return false; }


            if (wholelist[2].Equals(wholelist[6]))
            { return false; }

            if (wholelist[2].Equals(wholelist[10]))
            { return false; }

            if (wholelist[2].Equals(wholelist[14]))
            { return false; }


            if (wholelist[3].Equals(wholelist[7]))
            { return false; }

            if (wholelist[3].Equals(wholelist[11]))
            { return false; }

            if (wholelist[3].Equals(wholelist[15]))
            { return false; }

            else
            { return true; }
        }

        public bool checkSquares(List<int> wholelist)
        {
            if (wholelist[0].Equals(wholelist[1]))
            { return false; }

            if (wholelist[0].Equals(wholelist[4]))
            { return false; }

            if (wholelist[0].Equals(wholelist[5]))
            { return false; }

            if (wholelist[1].Equals(wholelist[4]))
            { return false; }

            if (wholelist[1].Equals(wholelist[5]))
            { return false; }

            if (wholelist[4].Equals(wholelist[5]))
            { return false; }


            if (wholelist[2].Equals(wholelist[3]))
            { return false; }

            if (wholelist[2].Equals(wholelist[6]))
            { return false; }

            if (wholelist[2].Equals(wholelist[7]))
            { return false; }

            if (wholelist[3].Equals(wholelist[6]))
            { return false; }

            if (wholelist[3].Equals(wholelist[7]))
            { return false; }

            if (wholelist[6].Equals(wholelist[7]))
            { return false; }


            if (wholelist[8].Equals(wholelist[9]))
            { return false; }

            if (wholelist[8].Equals(wholelist[12]))
            { return false; }

            if (wholelist[8].Equals(wholelist[13]))
            { return false; }

            if (wholelist[9].Equals(wholelist[12]))
            { return false; }

            if (wholelist[9].Equals(wholelist[13]))
            { return false; }

            if (wholelist[12].Equals(wholelist[13]))
            { return false; }


            if (wholelist[10].Equals(wholelist[11]))
            { return false; }

            if (wholelist[10].Equals(wholelist[14]))
            { return false; }

            if (wholelist[10].Equals(wholelist[15]))
            { return false; }

            if (wholelist[11].Equals(wholelist[14]))
            { return false; }

            if (wholelist[11].Equals(wholelist[15]))
            { return false; }

            if (wholelist[14].Equals(wholelist[15]))
            { return false; }

            else
            { return true; }
        }
    }
}
