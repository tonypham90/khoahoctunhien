using Newtonsoft.Json;
using Practive_KTLT.Service;

namespace Practive_KTLT.DAL;

public class Store_Item
{
    public static string CurrentDir = Environment.CurrentDirectory;
    public static DirectoryInfo directory = new DirectoryInfo(CurrentDir);
    public static FileInfo storedata = new FileInfo("ProductStore.json");
    public static FileInfo ItemType = new FileInfo("ItemType.json");
    public static bool Add_Item(Item s)
    {
        List<Item> productList = DownloadItemData();
        productList.Add(s);
        return UploadItemData(productList);
    }

    public static List<Item> DownloadItemData()
    {
        string dir = directory.FullName;
        StreamReader Read_data = new StreamReader(storedata.FullName);
        string jsonstring = Read_data.ReadToEnd();
        Read_data.Close();
        List<Item> itemData = JsonConvert.DeserializeObject<List<Item>>(jsonstring);
        return itemData;
    }
   
    public static bool UploadItemData(List<Item> itemData)
    {
        if (itemData.Count==0)
        {
            return false;
        }
        StreamWriter Write_data = new StreamWriter(directory.FullName + storedata.FullName);
        string jsonString = JsonConvert.SerializeObject(itemData);
        Write_data.Write(jsonString);
        return true;
    }
    
}