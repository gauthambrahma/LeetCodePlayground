using System;
using System.Collections.Generic;
using System.Linq;

namespace playground
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            IList<string> result = fizzBuzz.printFizzBuzz(15);
            foreach (string item in result) {
                Console.WriteLine(item);
            }
        }
    }
}
