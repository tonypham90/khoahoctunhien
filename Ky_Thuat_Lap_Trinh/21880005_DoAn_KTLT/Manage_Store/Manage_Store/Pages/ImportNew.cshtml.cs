using System.Security.Cryptography.X509Certificates;
using Manage_Store.DAL;
using Manage_Store.Entity;
using Manage_Store.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Manage_Store.Pages;

public class ImportNew : PageModel
{
    public static List<StrucItem>? CurrentListItems = DataWorkFlow.DownloadListItem();
    public bool Status;
    public string Notification { get; set; } = string.Empty;
    [BindProperty(SupportsGet = true)]
    public string ItemId { get; set; }
    [BindProperty]
    public string ItemName { get; set; }
    public string ItemManuf { get; set; }
    [BindProperty]
    public int ItemQty { get; set; }

    public string? NewImportId = ManipulateFunction.NewImportId();
    [BindProperty]
    public DateTime ImportDate { get; set; }
    [BindProperty]
    public int ImportQty { get; set; }
    
    public void OnGet()
    {
        StrucItem currentItem = SolvingItem.FindItem(ItemId, CurrentListItems);
        Notification = String.Empty;
        ItemName = currentItem.Name;
        ItemId = currentItem.Id;
        ItemQty = currentItem.Qty;
        ItemManuf = currentItem.Manufacture;
    }

    public void OnPost()
    {
        ImportRecord NewImport = new ImportRecord();
        NewImport.Date = DateManipulate.ConvertDatetoString(ImportDate);
        NewImport.ImportId = NewImportId;
        NewImport.ItemId = ItemId;
        NewImport.ImportQty = ImportQty;
        Status = ImportStore.RequestnewImport(NewImport);
        StrucItem currentItem = SolvingItem.FindItem(ItemId, CurrentListItems);
        ItemQty = currentItem.Qty;

        switch (Status)
        {
            case true:
                Notification = "Nhap Kho thanh cong";
                Response.Redirect("/index");
                break;
            case false:
                Notification = "Nhap Kho thanh cong";
                break;
        }
    }
}