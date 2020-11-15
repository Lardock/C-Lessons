using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleGlav1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MyConsole";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************");
            Console.WriteLine("Hello c#");
            Console.WriteLine("*******************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
            MessageBox.Show("Подключён!");
        }
    }
}
