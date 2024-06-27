using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relational_operator
{
   class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int x = 20, y = 10;
            result = (x == y); // Equal to Operator
            Console.WriteLine("Equal to Operator: " + result);//use concat to call "result"
            result = (x > y); // Greater than Operator
            Console.WriteLine("Greater than Operator: " + result);
            result = (x < y); // Less than Operator
            Console.WriteLine("Less than Operator: " + result);
            result = (x >= y); // // Greater than Equal to Operator
            Console.WriteLine("Greater than Equal to Operator: " + result);
            result = (x <= y); // Less than Equal to Operator
            Console.WriteLine("Less than Equal to Operator: " + result);
            result = (x != y); // Not Equal To Operator
            Console.WriteLine("Not Equal to Operator: " + result);
            Console.ReadLine();
        }
    }
}
