using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практическая_12._10;

namespace ConsoleApp1
{
    namespace _1
    {
        class Program
        {
            static void Main(string[] args)
            {
                Mylib asd = new Mylib();
                Mylib.sum(0, 0);
                Mylib.vichet(0, 0);
                Console.WriteLine($"Вы родились в {Mylib.Age(0)} году");
                Mylib.newname();
                Console.WriteLine("Нахождение дискриминанта: введите a, b, c");
                Console.WriteLine($"D={Mylib.D()}");
                Console.ReadLine();
            }
        }
    }
}
