﻿using System;

namespace Baitap23
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 23: Đếm số lượng “ước số” của số nguyên dương n");
            Console.WriteLine("Nhap gia tri n");
            int n = int.Parse(Console.ReadLine()!);
            int i = 0,r=0;
            while (i < n)
            {
                i++;
                
                if (n % i == 0)
                {
                    Console.WriteLine($"{i} la uoc so cua {n}");
                    r ++;
                }
            }
            Console.WriteLine($"dem cac gia tri uoc so {n} la {r}");
        }
    }
}