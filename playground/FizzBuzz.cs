using System;
using System.Collections;
using System.Collections.Generic;

namespace playground
{
    public class FizzBuzz
    {
      
        public IList<string> printFizzBuzz(int n)
        {

            IList<string> result = new List<String>();
            if (n < 1)
            {
                return result;
            }

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(.ToString());
                }
            }

            return result;
        }
    }    
}
