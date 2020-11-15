using System;

namespace IfElseCaseSIX
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maximum = 0;
            int Number1 = int.Parse(Console.ReadLine());
            int Number2 = int.Parse(Console.ReadLine());
            int Number3 = int.Parse(Console.ReadLine());
            Maximum = Maximum<Number1? Number1 : Maximum;
            Maximum = Maximum<Number2? Number2 : Maximum;
            Maximum = Maximum<Number3? Number3 : Maximum;
            Console.WriteLine("Максимум "+ Maximum);

            switch(Maximum%2){
                case 0:
                    Console.WriteLine("Число чётное");
                    break;
                default:
                    Console.WriteLine("Число не чётное");
                    break;         
            }

            Console.WriteLine(Maximum > 100 ? ("Да") : ("Нет"));
            Console.ReadLine();
        }
    }
}
