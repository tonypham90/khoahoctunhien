using Manage_Store.DAL;
using Manage_Store.Entity;
using Manage_Store.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Manage_Store.Pages;

public class ItemCreate : PageModel
{
    public List<string?>? ListLabel { get; set; }
    public bool StatusRequestAddItem { get; set; }
    [BindProperty]
    public string? ItemId { get; set; }
    [BindProperty]
    public string? ItemName { get; set; }
    [BindProperty]
    public string? ItemLabel { get; set; }
    [BindProperty]
    public string? ItemManu { get; set; }
    [BindProperty]
    public int ItemQty { get; set; }
    [BindProperty]
    public int ItemPrice { get; set; }
    [BindProperty]
    public DateTime ItemExp { get; set; }
    [BindProperty]
    public DateTime ItemMfg { get; set; }
    
    
    public void OnGet()
    {
        ItemId = ManipulateFunction.CreateItemId();
        ListLabel = DataWorkFlow.DownloadListLabel();
    }

    public void OnPost()
    {
        StrucItem newItem = new StrucItem();
        
        newItem.Id = ItemId;
        newItem.Name = ItemName;
        newItem.Manufacture = ItemManu;
        newItem.Qty = ItemQty;
        newItem.Label = ItemLabel;
        newItem.Exp = DateManipulate.ConvertDatetoString(ItemExp);
        newItem.Mfg = DateManipulate.ConvertDatetoString(ItemMfg);
        newItem.Price = ItemPrice;
        StatusRequestAddItem = SolvingItem.RequestAddItem(newItem);
    }
}