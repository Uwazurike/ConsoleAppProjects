using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int ace = 10;
            try
            {
                if (ace == 10)
                {
                    CustomException ex1 = new CustomException("Custom Exception was thrown");
                    throw ex1;
                }
                Exception ex2 = new Exception();
                throw ex2;
            }
            catch (CustomException e)
            {
                Console.WriteLine("A custom exception was thrown");
            }
            catch (Exception e2)
            {
                Console.WriteLine("An exception was thrown");
            }
            Console.WriteLine(ace);
            Console.ReadLine();
        }
    }

    class CustomException : Exception
    {
        public CustomException(string message)
        {
        }
    }
}