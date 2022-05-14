namespace RazorAppLearn.Service;
using RazorAppLearn.Entities;

public class XulyPhanSo
{
    public static PhanSo Tong2PhanSo(PhanSo first,PhanSo second)
    {
        PhanSo Result;
        Result.Tuso = first.Tuso * second.Mauso + first.Mauso * second.Tuso;
        Result.Mauso = first.Mauso * second.Mauso;
        //toi gian phan so
        bool isnotmin = true;
        while (isnotmin)
        {
            int Numberdevide=0;
            for (int i = 2; i < 9; i++)
            {
                if (Result.Tuso%i==0&& Result.Mauso%i==0)
                {
                    Numberdevide=i;
                }
            }

            if (Numberdevide!=0)
            {
                Result.Mauso /= Numberdevide;
                Result.Tuso /= Numberdevide;
            }
            else
            {
                isnotmin = false;
            }
        }

        return Result;
    }

    public static string PrintPhanSo(PhanSo Value)
    {
        return $"{Value.Tuso}/{Value.Mauso}";
    }
}