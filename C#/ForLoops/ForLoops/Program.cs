using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Write("*");
                }
                for (int j = 0; j < 1; j++)
                {
                    Write("**");
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}
