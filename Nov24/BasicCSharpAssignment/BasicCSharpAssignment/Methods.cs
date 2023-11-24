using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    public class Methods
    {
        public int CalculateFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * CalculateFactorial(num-1);        
        }
    }
}
