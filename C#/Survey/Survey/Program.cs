using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int correct = 0;
            Console.WriteLine("What is 1 + 1?" + "\n a) 3" + "\n b) 5" + "\n c) 2" + "\n d) 1");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your answer was {x}. ");
            Console.WriteLine("Correct answer is 2");

            Console.WriteLine("\n What is the Square Root of 16?" +  "\n a) 4" + "\n b) 8" + "\n c) 3" + "\n d) 12");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your answer was {y}. ");
            Console.WriteLine("Correct answer is 4");
            
            Console.WriteLine("\n What is 6^2?" + "\n 42" + "\n 36" + "\n 12" + "\n 24");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your anwser was {z}. ");
            Console.WriteLine("Correct Answer is 4");

            if (x == 2)
            { correct++; }
            if (y == 4)
            { correct++; }
            if (z == 36)
            { correct++; }
            Console.WriteLine($"You got {correct} answers correct");
            Console.ReadKey();
        }
    }
}
