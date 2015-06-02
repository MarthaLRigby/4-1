using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            int y = 5;
            int result = x+y;
            Console.WriteLine("Sum: {0} + {1} = {2}",x,y,result);
            result = x - y;
            Console.WriteLine("Diffenece: {0} - {1} = {2}", x, y, result);
            result = x * y;
            Console.WriteLine("Product: {0} * {1} = {2}", x, y, result);
            result = x / y;
            Console.WriteLine("Quotient: {0} / {1} = {2}", x, y, result);
            result = x % y;
            Console.WriteLine("Modulus: {0} % {1} = {2}", x, y, result);
        }
    }
}
