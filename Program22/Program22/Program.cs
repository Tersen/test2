using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program22
{
    class Program
    {
        static void Main(string[] args)
        {

            const int rozmiarTablic = 5;
            string[] Nazwiska = new string[5];
            Console.WriteLine("Wypełnij tablicę nazwiska:");
            for (int i = 0;i<rozmiarTablic;i++)
            {
                Console.Write("Nazwisko[{0}] = ", i);
                Nazwiska[i] = Convert.ToString(Console.ReadLine());   
            }
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(Nazwiska[i]+"");          
            }
            Console.ReadLine();
        }
    }
}

