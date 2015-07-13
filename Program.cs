using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;

            Console.WriteLine("Введите первое предложение: ");
            a = Console.ReadLine();
            Console.WriteLine("Введите второе предложение: ");
            a +=  " " + Console.ReadLine();

            string[] array = a.Split();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "" ) continue;
                bool f = true;

                for (int j = 0; j < array.Length; j++ )
                {
                    if (array[j] == "" || i == j) continue;
                    if (array[i] == array[j])
                    {
                        array[j] = "";
                        f = false;
                    }
                }
                if (f) Console.WriteLine(array[i]);
                array[i] = ""; 

            }
            Console.ReadKey();
        }
    }
}
