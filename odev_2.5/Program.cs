using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Başlangıç: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Bitiş: ");
            int end = int.Parse(Console.ReadLine());
            Console.Clear();

            if (start < end) {
                for (int i = start; i <= end; i++) {
                    if (i % 5 == 0) {
                        Console.Write(i + " \n");
                    }
                }
            }
            else { Console.WriteLine("Errcode.Fatal[The beginning cannot be greater than the end.]"); }

            Console.ReadKey();
        }
    }
}
