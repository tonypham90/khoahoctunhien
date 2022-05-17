using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Manage_Store.Pages;

public class CreateItem : PageModel
{
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
    }

    public void OnPost()
    {
        
    }
}