﻿using System;

namespace BaiTap06
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 6: Tính S(n) = 1/1×2 + 1/2×3 +…+ 1/n x (n + 1)");
            double s = 0, n;
            double i = 0;
            Console.WriteLine("Nhap so lan tinh n");
            n = int.Parse(Console.ReadLine()!);
            while (i < n)
            {
                i++;
                // ReSharper disable once PossibleLossOfFraction
                s += 1/i * (i+1);
            }
            Console.WriteLine($"Ket qua bai toan la: {s:F}");
        }
    }
}