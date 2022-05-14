using System;

namespace Bai_Tap
{
    public class PhanSoFunction
    {
        public static Struc_Setup.PhanSo NhapPhanSo()
        {
            Struc_Setup.PhanSo phanSo_New = new Struc_Setup.PhanSo();
            Console.WriteLine("Nhap Phan so moi");
            Console.Write("Tu so:");
            phanSo_New.Tuso = int.Parse(Console.ReadLine()!);
            Console.Write("Mau so:");
            phanSo_New.Mauso = int.Parse(Console.ReadLine()!);
            return phanSo_New;
        }
        public static Struc_Setup.HonSo NhapHonSo()
        {
            Struc_Setup.HonSo Honso_New = new Struc_Setup.HonSo();
            Console.WriteLine("Nhap Hon so moi");
            Console.Write("Phan so Nguyen:");
            Honso_New.Nguyen = int.Parse(Console.ReadLine()!);
            Console.Write("Tu so:");
            Honso_New.Tu = int.Parse(Console.ReadLine()!);
            Console.Write("Mau so:");
            Honso_New.Mau = int.Parse(Console.ReadLine()!);
            return Honso_New;
        }
        public static Struc_Setup.ToaDoMatPhan NhapToaDoMatPhan()
        {
            Struc_Setup.ToaDoMatPhan toaDoMatPhan = new Struc_Setup.ToaDoMatPhan();
            Console.WriteLine("Nhap Toa Do moi");
            Console.Write("Toa Do x:");
            toaDoMatPhan.x = int.Parse(Console.ReadLine()!);
            Console.Write("Toa Do y:");
            toaDoMatPhan.y = int.Parse(Console.ReadLine()!);
            return toaDoMatPhan;
        }
        public static Struc_Setup.ToaDoKhongGian NhapToaDoKhongGian()
        {
            Struc_Setup.ToaDoKhongGian toaDoKhongGian = new Struc_Setup.ToaDoKhongGian();
            Console.WriteLine("Nhap Toa Do moi");
            Console.Write("Toa Do x:");
            toaDoKhongGian.x = int.Parse(Console.ReadLine()!);
            Console.Write("Toa Do y:");
            toaDoKhongGian.y = int.Parse(Console.ReadLine()!);
            Console.Write("Toa Do z:");
            toaDoKhongGian.z = int.Parse(Console.ReadLine()!);
            return toaDoKhongGian;
        }
    }
}