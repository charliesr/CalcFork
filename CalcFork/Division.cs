using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFork
{
    public class Division : IDivision
    {
        public  int CalDivision(int num1, int num2)
        {
            return num1/num2;
        }
    }
}
