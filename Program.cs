using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    class Program
    {
        


        static void Main(string[] args)
        {
            int Start, End;
            Console.WriteLine("please enter the start number:");
            Start = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the end number:");
            End = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("");
            for (int i = Start; i <= End; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % x == 0) sum++;
                }
                if (sum == 2)
                {
                    Console.WriteLine(i);
                    sum = 0;
                }
                else { sum = 0; continue; }
            }
            Console.ReadKey();





        }
    }
}  

