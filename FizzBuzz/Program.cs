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
            MakingFizzBuzz runProgram = new MakingFizzBuzz();
            runProgram.FizzBuzz();
            Console.ReadLine();
        }
    }
}
