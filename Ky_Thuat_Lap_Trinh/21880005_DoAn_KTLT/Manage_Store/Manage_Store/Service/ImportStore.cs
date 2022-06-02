using Manage_Store.DAL;
using Manage_Store.Entity;

namespace Manage_Store.Service;

public class ImportStore
{
    public static bool RequestnewImport(ImportRecord newImportRecord)
    {
        List<ImportRecord>? currentImportRecords = DataWorkFlow.LoadImportHistory();
        List<StrucItem>? currentItemsList = SolvingItem.RequestLoadStore();
        
        if (newImportRecord.ImportQty==0||string.IsNullOrEmpty(newImportRecord.Date))
        {
            return false;
        }
        currentImportRecords.Add(newImportRecord);
        StrucItem itemneedUpdate = SolvingItem.FindItem(newImportRecord.ItemId, currentItemsList);
        itemneedUpdate.Qty += newImportRecord.ImportQty;
        bool statusupdateItem = SolvingItem.RequestUpdateItem(newImportRecord.ItemId, itemneedUpdate);
        bool statusuploadImportRecord = DataWorkFlow.UploadImportHistory(currentImportRecords);
        return statusupdateItem && statusuploadImportRecord;
    }

    public static List<ImportRecord> RequestLoadImportRecords()
    {
        return DataWorkFlow.LoadImportHistory();
    }

    public static List<ImportRecord> FindListRecords(string keyword, string function)
    {
        List<ImportRecord> resList = new List<ImportRecord>();
        List<ImportRecord> currentRecords = DataWorkFlow.LoadImportHistory();
        switch (function)
        {
            case "1":
                foreach (ImportRecord record in currentRecords)
                {
                    if (record.ImportId.Contains(keyword))
                    {
                        resList.Add(record);
                    }
                }
                break;
            case "2":
                foreach (ImportRecord record in currentRecords)
                {
                    if (record.ItemId.Contains(keyword))
                    {
                        resList.Add(record);
                    }
                }
                break;
            case "3":
                foreach (ImportRecord record in currentRecords)
                {
                    if (record.Date.Contains(keyword))
                    {
                        resList.Add(record);
                    }
                }
                break;
        }
        return resList;
    }

    public static bool RequestUpdateImportRecord(ImportRecord newRecord)
    {
        List<ImportRecord> currentRecords = RequestLoadImportRecords();
        List<StrucItem> currentItemsList = SolvingItem.RequestLoadStore();
        ImportRecord oldRecord = new ImportRecord();
        bool statusupdateItem = false, statusupdateRecord = false;
        
        foreach (ImportRecord record in currentRecords)
        {
            if (record.ImportId.Contains(newRecord.ImportId))
            {
                oldRecord = record;
            }
        }
        StrucItem oldItem = SolvingItem.FindItem(oldRecord.ItemId, currentItemsList);
        oldItem.Qty += newRecord.ImportQty - oldItem.Qty;
        for (int i = 0; i < currentItemsList.Count; i++)
        {
            if (currentItemsList[i].Id.Contains(oldItem.Id))
            {
                currentItemsList[i] = oldItem;
                statusupdateItem = SolvingItem.RequestUpdateItem(oldItem.Id, oldItem);
            }
        }

        for (int i = 0; i < currentRecords.Count; i++)
        {
            if (currentRecords[i].ImportId.Contains(newRecord.ImportId))
            {
                currentRecords[i] = newRecord;
                statusupdateRecord = DataWorkFlow.UploadImportHistory(currentRecords);
            }
        }

        return statusupdateItem && statusupdateRecord;
    }

    public static bool RequestRemoveImportReport(string importId)
    {
        List<ImportRecord> currentImportRecords = RequestLoadImportRecords();
        List<StrucItem> currentItemsList = SolvingItem.RequestLoadStore();
        bool statusupdateItem = false, statusremoveImportRecord = false;
        ImportRecord importRecordneedremove = new ImportRecord();
        foreach (ImportRecord record in currentImportRecords)
        {
            if (record.ImportId.Contains(importId))
            {
                importRecordneedremove = record;
                break;
            }
        }

        StrucItem itemUpdate = SolvingItem.FindItem(importRecordneedremove.ItemId, currentItemsList);
        int variance = itemUpdate.Qty - importRecordneedremove.ImportQty;
        if (variance<0)
        {
            itemUpdate.Qty = 0;
        }
        else
        {
            itemUpdate.Qty = variance;
        }

        statusupdateItem = SolvingItem.RequestUpdateItem(itemUpdate.Id, itemUpdate);
        currentImportRecords.Remove(importRecordneedremove);
        statusremoveImportRecord = DataWorkFlow.UploadImportHistory(currentImportRecords);
        return statusupdateItem && statusremoveImportRecord;
    }
}