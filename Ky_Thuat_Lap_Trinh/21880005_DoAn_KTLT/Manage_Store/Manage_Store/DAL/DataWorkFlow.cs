using Newtonsoft.Json;

namespace Manage_Store.DAL;

public static class DataWorkFlow
{
    private static readonly string CurrentDir = Environment.CurrentDirectory;
    private static readonly DirectoryInfo DirectoryInfo = new DirectoryInfo(CurrentDir);
    private static readonly FileInfo ItemLabelList = new FileInfo("DataLabel.json");
    private static readonly FileInfo ImportRecord = new FileInfo("DataImportHistory.json");
    private static readonly FileInfo SaleRecord = new FileInfo("DataSaleHistory.json");
    private static readonly FileInfo ItemStore = new FileInfo("DataStore.json");
    
    //space for label
    public static bool AddNewLabel(string newLabel)
    {
        newLabel = newLabel.ToUpper();
        List<string> currentLabel = DownloadListLabel();
        if (currentLabel.Contains(newLabel))
        {
            return false;
        }
        currentLabel.Add(newLabel);
        return UploadLabel(currentLabel);
        
    }

    public static List<string> DownloadListLabel()
    {
        List<string> resList = new List<string>();
        StreamReader fileReader = new StreamReader(ItemLabelList.FullName);
        string jsonstring = fileReader.ReadToEnd();
        fileReader.Close();
        if (string.IsNullOrEmpty(jsonstring))
        {
            return resList;
        }
        resList = JsonConvert.DeserializeObject<List<string>>(jsonstring) ?? throw new InvalidOperationException();
        return resList;
    }

    public static bool UploadLabel(List<string> listLabel)
    {
        if (listLabel.Count==0)
        {
            return false;
        }
        StreamWriter fileWriter = new StreamWriter(ItemLabelList.FullName);
        string jsonstring = JsonConvert.SerializeObject(listLabel);
        fileWriter.Write(jsonstring);
        fileWriter.Close();
        return true;
    }
    
    //end space for label

    //Store info

    //End Of store info

    //import store

    //End Import

    //Sale record
}