using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class MakingFizzBuzz
    {
        public void FizzBuzz()
        {
            for (var number = 0; number <= 100; number++)
            {

                if (number == 0)
                {
                    Console.WriteLine(0);
            
                }

                else if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
            
                }

                else if (number % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }

                else if (number % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }

                else
                {
                    Console.WriteLine(number);
            
                }
            }
        }
    }
}
