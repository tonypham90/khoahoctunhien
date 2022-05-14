using System;

namespace Bai_Tap
{
    public class Print
    {
        public static void Print_PhanSo(Struc_Setup.PhanSo value)
        {
            string text = $"{value.Tuso}/{value.Mauso}";
            Console.WriteLine(text);
        }

        public static void Print_HonSo(Struc_Setup.HonSo value)
        {
            string text = $"{value.Nguyen} {value.Tu}/{value.Mau}";
            Console.WriteLine(text);
        }

        public static void Print_ToadoMatPhan(Struc_Setup.ToaDoMatPhan toaDoMatPhan)
        {
            string text = $"Toa do x = {toaDoMatPhan.x}, y = {toaDoMatPhan.y}";
            Console.WriteLine(text);
        }

        public static void Print_ToaDoKhongGian(Struc_Setup.ToaDoKhongGian toaDoKhongGian)
        {
            string text = $"Toa do x = {toaDoKhongGian.x}, y = {toaDoKhongGian.y}, z = {toaDoKhongGian.z}";
        }
    }
}