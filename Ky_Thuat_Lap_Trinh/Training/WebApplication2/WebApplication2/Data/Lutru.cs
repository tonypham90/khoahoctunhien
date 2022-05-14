using Newtonsoft.Json;
using WebApplication2.Services;

namespace WebApplication2.Data;

public class Lutru
{
    public static void Luutamgiacfile(Rectangle t)
    {
        StreamWriter file = new StreamWriter("/Users/tonypham/RiderProjects/khoahoctunhien/Ky_Thuat_Lap_Trinh/Training/WebApplication2/WebApplication2/Database/luudiem.txt");
        // foreach (Diem2D point in t)
        // {
        //     file.WriteLine($"{point.X},{point.Y}");
        // }
        file.WriteLine($"{t.A.X},{t.A.Y}");
        file.WriteLine($"{t.B.X},{t.B.Y}");
        file.Write($"{t.C.X},{t.C.Y}");
        file.Close();
        
    }
    public static void Luutamgiac(Rectangle t)
    {
        StreamWriter file = new StreamWriter("/Users/tonypham/RiderProjects/khoahoctunhien/Ky_Thuat_Lap_Trinh/Training/WebApplication2/WebApplication2/Database/luudiem.json");
        string s = JsonConvert.SerializeObject(t);
        file.WriteLine(s);
        file.Close();
        
    }
    

    public static Diem2D doc()
    {
        Diem2D kq = default;
        StreamReader file = new StreamReader("/Users/tonypham/RiderProjects/khoahoctunhien/Ky_Thuat_Lap_Trinh/Training/WebApplication2/WebApplication2/Database/luudiem.json");
        string text = file.ReadToEnd();
        kq = JsonConvert.DeserializeObject<Diem2D>(text);
        file.Close();
        return kq;


    }

    public static void Luudiem(Diem2D A)
    {
        StreamWriter file = new StreamWriter("/Users/tonypham/RiderProjects/khoahoctunhien/Ky_Thuat_Lap_Trinh/Training/WebApplication2/WebApplication2/Database/luudiem.json");
        string json = JsonConvert.SerializeObject(A);
        file.WriteLine(json);
        file.Close();
    }
}