﻿namespace P06_ReplaceRepChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string result = string.Empty;
            for (int i = 0;i<input.Length-1;i++)
            {
                if (input[i] == input[i+1])
                {
                    continue;
                }
                result += input[i];
            }
            result += input[input.Length - 1];
            Console.WriteLine(result);
        }
    }
}