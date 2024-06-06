using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApp
{
    public class FizzBuzz
    {
        public int Tour { get; }

        public FizzBuzz(int tour = 1)
        {
            this.Tour = tour;
        }

        public bool IsValidInput(string input)
        {
            if (Tour % 3 == 0)
            {
                return input == "Fizz";
            }
            else
            {
                return input == Tour.ToString();
            }
        }
    }
}
