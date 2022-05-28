using System.ComponentModel.DataAnnotations;
using Practive_KTLT.DAL;

namespace Practive_KTLT.Service;

public class SolvingItem
{
    private static readonly DateTime DateTimeLowBound = new DateTime(1900,1,1);
    public static bool CreateItem(Item product)
    {
        if (string.IsNullOrWhiteSpace(product.Name)||
            string.IsNullOrWhiteSpace(product.Type)||
            product.Price<0||
            product.Exp<DateTimeLowBound||product.Mfg<DateTimeLowBound||
            product.Exp<product.Mfg)
        {
            return false;
        }

        return StoreItem.Add_Item(product);
    }

    public static List<Item> SearchKeyWordItems(string keyWord)
    {
        
        List<Item> resList = new List<Item>();
        List<Item> storeList = StoreItem.DownloadItemData();
        if (string.IsNullOrEmpty(keyWord))
        {
            resList = storeList;
            return resList;
        }
        foreach (Item item in storeList)
        {
            if (Function.IsTextContainChar(keyWord,item.Name))
            {
                resList.Add(item);
            }
        }

        return resList;
    }
}