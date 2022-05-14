using WebApplication2.Data;

namespace WebApplication2.Services;

public class XuLyPhanSo
{
    public static PhanSo TongPhanSo(PhanSo a, PhanSo b)
    {
        PhanSo kq;
        kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
        kq.MauSo = a.MauSo * b.MauSo;
        return kq;
    }

    public static string InPhanSo(PhanSo phanSo)
    {
        string a = $"{phanSo.TuSo}/{phanSo.MauSo}";
        return a;
    }

    public static bool luuphanso(PhanSo a)
    {
        if (a.MauSo == 0)
        {
            return false;
        }
        Luutruphanso.luu(a);
        return true;
    }
    
}