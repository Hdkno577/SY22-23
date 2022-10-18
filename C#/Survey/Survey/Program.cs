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
            Console.WriteLine("Please Answer With the Letter Coresponding to the Answer");
            ShowQuestion("\nWhat is 1+1?", " a)1", " b)3", " c) 0", " d) 2", "d");
            ShowQuestion("\nWhat is the square root of 16?", " a)4", " b)5", " c) 0", " d) 6", "a");
            ShowQuestion("\nWhat is 6 squared?", " a)42", " b)36", " c) 45", " d) 6", "12");
            Console.ReadKey();

            ;
        }
        public static void ShowQuestion(string question,
                                        string answer1,
                                        string answer2,
                                        string answer3,
                                        string answer4,
                                        string correct)
        {
            Console.WriteLine(question);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            string answer = Console.ReadLine();
            if (answer.Equals(correct))
                Console.WriteLine("You Got it Correct");
        }
    }
}

