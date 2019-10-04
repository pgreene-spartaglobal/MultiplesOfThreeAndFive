using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesThreeAndFive
{
    public class MultiplesOfThreeAndFiveClass
    {
        public int SumMultiplesOfThreeAndFive(int v)
        {
            int total = 0;
            for (int i = 0; i < v; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }
            return total;
        }
    }
}
