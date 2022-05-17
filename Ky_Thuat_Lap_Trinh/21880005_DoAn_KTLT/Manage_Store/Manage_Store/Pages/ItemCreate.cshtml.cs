using Manage_Store.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Manage_Store.Pages;

public class ItemCreate : PageModel
{
    public List<string> ListLabel { get; set; }
    public string notification { get; set; }
    public string ItemId { get; set; }
    [BindProperty]
    public string ItemName { get; set; }
    [BindProperty]
    public string ItemLabel { get; set; }
    [BindProperty]
    public string ItemManu { get; set; }
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
        notification = string.Empty;
        ItemId = string.Empty;
        ListLabel = DataWorkFlow.DownloadListLabel();
    }

    public void OnPost()
    {
        
    }
}