using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1-A
            Console.WriteLine("A.please enter any word/sentence, return reverse order:");
            string inputA = Console.ReadLine();
            Console.WriteLine($"reverse is : {QuestionA(inputA)}");
            //Q1-B
            Console.WriteLine("B.please enter any word/sentence, return reverse order and separate by \" \":");
            string inputB = Console.ReadLine();
            Console.WriteLine($"reverse with \" \" is : {QuestionB(inputB)}");

            //Q2
            Console.WriteLine("input:");
            int inputQ2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"reverse with \" \" is : {Question2(inputQ2).ToString()}");

            //Q4
            //270是每個人所出的錢，表示實際上他們的花費是810元，並且包含服務生暗康的60，應是810-60=750特價才合理。
        }

        static string QuestionA(string input)
        {
            string result = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            return result;
        }

        static string QuestionB(string input)
        {
            string[] inputList = input.Split(' ');
            string result = "";
            for (int i = 0; i < inputList.Length; i++)
            {
                result += QuestionA(inputList[i]) + " ";
            }
            return result;
        }
        static int Question2(int input)
        {
            List<int> remove = new List<int>();
            for (int i = 0; i < input; i++)
            {
                if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
                {
                    remove.Add(i);
                }
            }
            return input - remove.Count;
        }
    }
}
