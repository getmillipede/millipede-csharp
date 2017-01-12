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
            int i = 0;
            int size = 20;
            bool isReverse = false;
            string head = "╚⊙ ⊙╝";
            string body = "╚═(███)═╝";

            if (args.Length > 0)
            {
                for (i = 0; i < args.Length; i++)
                {
                    string tok = args[i];
                    int tmp = 0;
                    if (!int.TryParse(tok, out tmp) && !isReverse)
                        isReverse = tok == "-r";
                    else
                        size = tmp;
                }
            }
            if (isReverse)
            {
                head = "╔⊙ ⊙╗";
                body = "╔═(███)═╗";
                for (i = size; i > 0; i--)
                {
                    Console.WriteLine(new string(' ', padding_offsets[i % 9]) + body);
                }
                Console.WriteLine(new string(' ', padding_offsets[i % 9]+1) + head);
            }
            else
            {
                Console.WriteLine(new string(' ', padding_offsets[0]+1) + head);
                for (i = 1; i < size; i++)
                {
                    Console.WriteLine(new string(' ', padding_offsets[i % 9]) + body);
                }
            }
        }
    }
}
