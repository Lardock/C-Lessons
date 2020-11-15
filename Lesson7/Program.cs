using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа");
            List<int> NumbersL = new List<int>();
            int Sum=0;
            int Diff=0;
            int Composition=1;
            for (int i=0;i<10 ;)
            {
                Console.Write("Число "+ (i+1) + " |  ");
                string ConsRead = Console.ReadLine();
                int Number;
                bool StringError = int.TryParse(ConsRead, out Number);
                if (StringError)
                {
                    NumbersL.Add(Number);
                    i++;
                    Sum += Number;
                }
                else
                {
                    Console.WriteLine("Ошибка. Введите число");
                }
            }

            int CounterWhile = 0;
            while(CounterWhile< NumbersL.Count)
            {
                Diff -= NumbersL[CounterWhile];
                CounterWhile++;
            }

            int CounterDoWhile = 0;
            do
            {
                Composition *= NumbersL[CounterDoWhile];
                CounterDoWhile++;
            }
            while (CounterDoWhile < NumbersL.Count);


            Console.WriteLine(new String('=',20));
            Console.WriteLine("Ваши числа");
            foreach (int item in NumbersL)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string ('=', 20));
            Console.WriteLine("Сумма чисел : "+ Sum);
            Console.WriteLine("Разность чисел : "+ Diff);
            Console.WriteLine("Произведение чисел : "+ Composition);
        }
    }
}
