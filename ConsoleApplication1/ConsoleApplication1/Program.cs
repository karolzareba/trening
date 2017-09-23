using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 2;
            for (int q = 1; q < 32; q = q * 2)
            {
                while (p < q) {
                    p = p * 2;
                }
                q = p - q;
            }

        }

    }
}
