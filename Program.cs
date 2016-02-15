using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static private int Square(int argument)
        {
            int result;
            result = checked(argument * argument);
            if (result < 0)
                throw new Exception("Square function should not return negative values!");
            return result;

        }

        static void Main(string[] args)
        {
            try
            {
                int x = 1234;
                int y = Square(x);
                y = Square(y);
                string sy = y.ToString();
                Console.WriteLine(sy);                
            }
            catch (Exception ex)
            {
                ConsoleColor currentColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine("Error: " + ex.Message);
                Console.ForegroundColor = currentColor;
            }

            
        }
    }
}
