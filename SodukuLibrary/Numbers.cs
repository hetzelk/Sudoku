using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodukuLibrary
{
    public class Numbers
    {
        public int cubeint = 4;//this should be a variable, not necissarily 4
        
        public void getCube(int numbercube)
        {
            cubeint = numbercube;//I couldn't figure out how to use properties the correct way to set the cubeint variable. So just for my trials, I hard-coded 4 into it.
        }
    }       
}
