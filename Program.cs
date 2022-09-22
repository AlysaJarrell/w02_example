using System;
using System.Collections.Generic;

namespace w02_example // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Bob");
            names.Add("Bill");
            names.Add("Sue");
            
            names.ForEach(name => Console.Write(name + " "));

            string aString = "a";
            List<string> stuff = new List<string> {aString, "b", "c","d" };

            char aSingleCharacter = 'e';
            Console.WriteLine($"This is a single character: {aSingleCharacter}");

            int x = 5;
            int y = 7;
            int result = Adder(x,y); // 12

            int result2 = Adder(10, 46); // 56

            Console.WriteLine($"these are my results: {result}. Result 2: {result2}");

        }

        static int Adder(int a, int b)
        {
            return a + b;
        }



    }
}
