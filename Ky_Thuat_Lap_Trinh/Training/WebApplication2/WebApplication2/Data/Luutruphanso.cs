using WebApplication2.Services;

namespace WebApplication2.Data;

public class Luutruphanso
{
    public static void luu(PhanSo a)
    {
        StreamWriter file = new StreamWriter("/Users/tonypham/RiderProjects/khoahoctunhien/Ky_Thuat_Lap_Trinh/Training/WebApplication2/WebApplication2/Database/luu.txt");
        file.Write($"{a.TuSo}/{a.MauSo}");
        file.Close();
    }
}