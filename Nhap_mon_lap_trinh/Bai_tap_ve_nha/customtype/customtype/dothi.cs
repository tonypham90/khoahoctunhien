using System;

namespace customtype
{
    public struct Toado
    {
        public float X;
        public float Y;
    }
    public class Dothi
    {
        public static Toado NhapToaDo(string ghichu)
        {
            Console.WriteLine(ghichu);
            Toado a;
            Console.WriteLine("Toa do x: ");
            a.X = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Toa do y: ");
            a.Y = float.Parse(Console.ReadLine()!);
            return a;
        }

        public static float Spacing(Toado a, Toado b)
        {
            float kq,x,y;
            x = a.X - b.X;
            y = a.Y - b.Y;
            kq = (float)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            /*Console.WriteLine($"Khoan cach la: {kq:F} ");*/
            return kq;
        }

        public static float ChuVi(Toado a, Toado b, Toado c)
        {
            float chuvi;
            chuvi = Dothi.Spacing(a, b) + Dothi.Spacing(b, c) + Dothi.Spacing(a, c);
            return chuvi;
        }
    }
}