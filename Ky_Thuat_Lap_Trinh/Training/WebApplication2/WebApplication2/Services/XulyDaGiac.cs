using WebApplication2.Data;

namespace WebApplication2.Services;

public class XulyDaGiac
{
    public static Dagiac Doc()
    {
        Dagiac t = LuutruDaGiac.Doc();
        return t;

    }
}