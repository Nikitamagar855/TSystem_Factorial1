using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NO YOU WANT FACTOTIAL OF");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            int fact = 1;
            for(i=1;i<=num;i++)
            {
                fact = fact * i;
                Console.WriteLine("FACTORIAL OF"+num+ "="+fact);
            }
            Console.ReadLine();
        }
    }
}
