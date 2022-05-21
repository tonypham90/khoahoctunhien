using Manage_Store.DAL;
using Manage_Store.Entity;

namespace Manage_Store.Service;

public class SolvingItem
{
    public static bool RequestAddItem(StrucItem item)
    {
        List<StrucItem> listItem = DataWorkFlow.DownloadListItem();
        listItem.Add(item);
        return DataWorkFlow.UploadItemList(listItem);
        
    }
}