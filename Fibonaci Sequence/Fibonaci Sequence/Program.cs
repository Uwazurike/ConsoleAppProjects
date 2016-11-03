using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght;
            Console.Title = ("Fibonaci Sequence");
            Console.Write("\n");
            Console.Write("Please Enter A Number");
            lenght = Convert.ToInt32(Console.ReadLine());
            FibonacciTemp(0, 1, 1, lenght);
            Console.ReadLine();
        }

        private static void FibonacciTemp(int firstNumber, int secondNumber, int numCount, int lenght)
        {
            if (numCount <= lenght)
            {
                Console.Write("{0} ", firstNumber);
                FibonacciTemp(secondNumber, firstNumber + secondNumber, numCount + 1, lenght);
            }
        }
    }
}
