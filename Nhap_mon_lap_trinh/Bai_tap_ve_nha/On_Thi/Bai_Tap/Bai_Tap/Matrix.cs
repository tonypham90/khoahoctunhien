using System;
using System.Reflection.Metadata;

namespace Bai_Tap
{
    public class Matrix
    {
        public static int[,] NewMatrix(int rownNo, int columnNo)
        {
            Console.WriteLine("Tạo dữ liệu ma trận mới 2 chiều");
            Console.WriteLine("Nhap so cot ");
            int[,] newMatrix = new int[rownNo,columnNo];
            int count = 0;
            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    Console.Write($"Nhap du lieu vi tri [{i+1},{j+1}]:");
                    newMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return newMatrix;
        }
    }
}