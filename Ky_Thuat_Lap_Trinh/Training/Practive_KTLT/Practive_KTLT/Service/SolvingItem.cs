using System.ComponentModel.DataAnnotations;
using Practive_KTLT.DAL;

namespace Practive_KTLT.Service;

public class SolvingItem
{
    private static DateTime DateTime_Lowbound = new DateTime(1900,1,1);
    public static bool CreateItem(Item product)
    {
        if (string.IsNullOrWhiteSpace(product.Name)||
            string.IsNullOrWhiteSpace(product.Type)||
            product.Price<0||
            product.Exp<DateTime_Lowbound||product.Mfg<DateTime_Lowbound||
            product.Exp<product.Mfg)
        {
            return false;
        }

        return Store_Item.Add_Item(product);
    }
}