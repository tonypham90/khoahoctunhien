using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practive_KTLT.Service;

namespace Practive_KTLT.Pages;

public class CreateItem : PageModel
{
    public string Text;
    [BindProperty]
    public string ItemId { get; set; }
    [BindProperty]
    public string ItemName { get; set; }
    [BindProperty]
    public int ItemQty { get; set; }
    [BindProperty]
    public DateTime ItemExp { get; set; }
    [BindProperty]
    public DateTime ItemMfg { get; set; }
    [BindProperty]
    public string ItemType { get; set; }
    [BindProperty]
    public float ItemPrice { get; set; }
    

    public void OnGet()
    {
        Text = string.Empty;
    }

    public void OnPost()
    {
        Item product ;
        product.Name = ItemName;
        product.Id = ItemId;
        product.Exp = ItemExp;
        product.Mfg = ItemMfg;
        product.Qty = ItemQty;
        product.Price = ItemPrice;
        product.Type = ItemType;
        bool result =SolvingItem.CreateItem(product);
        Text = $"input data {result}";
    }
}