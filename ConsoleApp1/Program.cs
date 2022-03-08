using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 23, 23, 34, 12, 423, 5, 43 };
            int search = 43;
            Console.WriteLine(number(arry, search));
            Console.Read();
        }
        static bool number(int[] arry, int search)
        {
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] == search)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
