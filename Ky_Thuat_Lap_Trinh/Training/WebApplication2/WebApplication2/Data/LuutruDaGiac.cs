using WebApplication2.Services;

namespace WebApplication2.Data;

public class LuutruDaGiac
{
    public static Dagiac Doc()
    {
        Diem2D a;
        Dagiac t;
        StreamReader file = new StreamReader("/Users/tonypham/RiderProjects/khoahoctunhien/Ky_Thuat_Lap_Trinh/Training/WebApplication2/WebApplication2/Database/luudiem.txt");
        string[] alldata = file.ReadToEnd().Split("\n");
        t.DanhSachDinh = new Diem2D[alldata.Length];
        for (int i = 0; i < alldata.Length; i++)
        {
            
            string[] inf = alldata[i].Split(",");
            a.X = Double.Parse(inf[0]);
            a.Y = Double.Parse(inf[1]);
            t.DanhSachDinh[i] = a;
        }

        return t;
    }
}