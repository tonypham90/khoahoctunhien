using System;

namespace customtype
{
    public struct DAGIAC
    {
        public Toado[] DSDinh;
    }
    public class xulydagiac
    {
        
            public static DAGIAC NhapDaGiac(String ghichu)
            {
                DAGIAC kq;
                Console.WriteLine(ghichu);
                Console.WriteLine("So dinh cua da giac: ");
                int countpoint = int.Parse(Console.ReadLine()!);
                kq.DSDinh = new Toado[countpoint];
                for (int i = 0; i < kq.DSDinh.Length; i++)
                {
                    kq.DSDinh[i] = Dothi.NhapToaDo($"Nhap toa do diem thu {i + 1}");
                }

                return kq;
            }

            public static float TinhChuVi(DAGIAC d)
            {
                float chuVi = 0;
                for (int i = 0; i < d.DSDinh.Length-1; i++)
                {
                    chuVi += Dothi.Spacing(d.DSDinh[i], d.DSDinh[i + 1]);
                }

                chuVi += Dothi.Spacing(d.DSDinh[0], d.DSDinh[d.DSDinh.Length - 1]);
                return chuVi;
            }
    }
}