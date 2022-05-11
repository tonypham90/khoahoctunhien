using WebApplication2.Data;

namespace WebApplication2.Services;

public class Khonggian
{
    public static double Spacing2Point(Diem2D a, Diem2D b)
    {
        double spacing = Math.Sqrt(Math.Pow(a.X-b.X,2)+Math.Pow(a.Y-b.Y,2));
        return spacing;
    }

    public static double Perimeter(Rectangle t)
    {
        double result = Spacing2Point(t.A, t.B) + Spacing2Point(t.B, t.C) + Spacing2Point(t.C, t.A);
        return result;
    }

    public static bool IsRectangle(Rectangle t)
    {
        double x, y, z;
        x = Spacing2Point(t.A, t.B);
        y = Spacing2Point(t.B, t.C);
        z = Spacing2Point(t.C, t.A);
        bool check = x + y > z && y + z > x && z + x > y;
        return check ;
    }
    
    public static bool SaveRectangle(Rectangle t)
    {
        if (IsRectangle(t)==false)
        {
            // kiem tra hop le tam giac
            return false;
        }
        Lutru.Luutamgiac(t);
        return true;
    }

    public static Diem2D Docdiem()
    {
        Diem2D kq;
        kq = Lutru.doc();
        return kq;
    }
    public static bool luudiem(Diem2D a)
    {
        Lutru.Luudiem(a);
        return true;
    }
}