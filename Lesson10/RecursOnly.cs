using System;

namespace Lesson10
{
    class RecursOnly
    {
        private int numbr;
        public int Numbr
        {
            get
            {
                return numbr;
            }
            set
            {
                numbr=value;
            }
        }
        public RecursOnly()
        {
            Console.WriteLine("Insert the number");
            int.TryParse(Console.ReadLine(),out numbr);
            numbr = Recursion(numbr);
            Console.WriteLine(new String('=',20) );
            Console.WriteLine($"Your Fibonacci {numbr}");
        }
        public int Recursion(int numbr)
        {
            if (numbr<=1)
            {
                return 1;
            }
            else
            {
                return numbr*Recursion(numbr-1);
            }
        }
    }
}
