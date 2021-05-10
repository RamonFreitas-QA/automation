using Core;
using System;

namespace PalidromeWordConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra, iremos verificar se é uma palidrome !");
            string word = (Console.ReadLine());

            bool result = new CheckString(word.Trim()).CheckPalindromeString();

            if (result)
                Console.WriteLine($"A palavra {word}: é palindrome");
            else
                Console.WriteLine($"A palavra {word}: não é palindrome");
        }
    }
}
