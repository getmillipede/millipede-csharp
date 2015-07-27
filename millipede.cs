using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace millipede
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] padding_offsets = new int[] { 2, 1, 0, 1, 2, 3, 4, 4, 3 };
            int size = 20;

            if (args.Length > 1)
            {
                size = int.Parse(args[1]);
            }

            Console.WriteLine("    ╚⊙ ⊙╝");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string(' ', padding_offsets[i%9]) + "╚═(███)═╝");
            }
        }
    }
}
