﻿namespace Cezer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
               
                if (words[i].Equals(word))
                {
                    words[i] = new String('*', word.Length);
                }
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
