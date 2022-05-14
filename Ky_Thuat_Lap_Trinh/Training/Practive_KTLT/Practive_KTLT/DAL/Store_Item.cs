using Newtonsoft.Json;
using Practive_KTLT.Service;

namespace Practive_KTLT.DAL;

public class StoreItem
{
    private static string CurrentDir = Environment.CurrentDirectory;
    private static readonly DirectoryInfo Directory = new DirectoryInfo(CurrentDir);
    public static readonly FileInfo StoreLFileInfo = new FileInfo("ProductStore.json");
    private static readonly FileInfo ItemTypeFileInfo = new FileInfo("ItemType.json");
    public static bool Add_Item(Item s)
    {
        List<Item> productList = DownloadItemData();
        productList.Add(s);
        return UploadItemData(productList);
    }

    public static List<Item> DownloadItemData()
    {
        string dir = Directory.FullName;
        StreamReader readData = new StreamReader(StoreLFileInfo.FullName);
        string jsonstring = readData.ReadToEnd();
        readData.Close();
        List<Item> itemData = JsonConvert.DeserializeObject<List<Item>>(jsonstring);
        return itemData;
    }
   
    public static bool UploadItemData(List<Item> itemData)
    {
        if (itemData.Count==0)
        {
            return false;
        }
        StreamWriter writeData = new StreamWriter(StoreLFileInfo.FullName);
        string jsonString = JsonConvert.SerializeObject(itemData);
        writeData.Write(jsonString);
        return true;
    }
    
}