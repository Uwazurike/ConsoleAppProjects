using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoring
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Factorial Sequence");
            Console.Write("\n\n");
            Console.Write("Type number:\n");
            Console.Write("---------------------------------------------------------");
            Console.Write("\n\n");
            string answer = Console.ReadLine();
            int userAns = Convert.ToInt32(answer);
            for (int i = userAns; i > 0; i--)
            {
                Console.WriteLine();
                for (int x = i; x > 0; x--)
                {
                    if (x == 1)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(x + " x ");
                    }

                }
                int full = Fact(userAns);

                Console.Write(" = " + Fact(i));
                Console.ReadLine();
            }
        }
        static int Fact(int y)
        {
            if (y > 0)
            {
                return y * Fact(y - 1);
            }

            return 1;
        }

    }
}