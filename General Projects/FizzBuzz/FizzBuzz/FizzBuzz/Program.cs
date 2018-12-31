using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods runMethod = new Methods();
            runMethod.ValidateInput(args);

            Console.ReadLine();
        }
    }
}