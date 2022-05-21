using Manage_Store.DAL;
using Manage_Store.Entity;

namespace Manage_Store.Service;

public class SolvingItem
{
    public static bool RequestAddItem(StrucItem item)
    {
        bool isRequestGood = false ;
        List<StrucItem> listItem = DataWorkFlow.DownloadListItem();
        if (isRequestGood)
        {
            listItem.Add(item);
            isRequestGood = DataWorkFlow.UploadItemList(listItem);
        }
        return isRequestGood;
    }
}