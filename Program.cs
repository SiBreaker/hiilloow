using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ft(5));
        }

        static int ft(int a)
        {
            if (a == 1)
                return 1;
            return ft(a - 1) * a;
        }


    }
}
