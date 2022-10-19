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
                    WriteLine();
                    Write("**");
                    WriteLine();
                    Write("***");
                    WriteLine();
                    Write("****");
                    WriteLine();
                    Write("*****");
                }
                WriteLine();
            }
            for (int i = 0; i < 1; i++)
            {
                Write("    *");
                WriteLine();
                Write("   **");
                WriteLine();
                Write("  ***");
                WriteLine();
                Write(" ****");
                WriteLine();
                Write("*****");
                WriteLine();
            }
            for (int i = 0; i < 1; i++)
            {
                Write("    *    ");
                WriteLine();
                Write("   ***   ");
                WriteLine();
                Write("  *****  ");
                WriteLine();
                Write(" ******* ");
                WriteLine();
                Write("*********");
                WriteLine();
            }
            for (int i = 0; i < 1; i++)
            {
                Write("    1    ");
                WriteLine();
                Write("   222   ");
                WriteLine();
                Write("  33333  ");
                WriteLine();
                Write(" 4444444 ");
                WriteLine();
                Write("555555555");
                WriteLine();
            }
            for (int i = 0; i < 1; i++)
            {
                Write("    1    ");
                WriteLine();
                Write("   212   ");
                WriteLine();
                Write("  32123  ");
                WriteLine();
                Write(" 4321234 ");
                WriteLine();
                Write("543212345");
                WriteLine();
            }
            ReadKey();
        }
    }
}
