﻿namespace Numbers_ending_with_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            for (int i = 7; i <= n; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}