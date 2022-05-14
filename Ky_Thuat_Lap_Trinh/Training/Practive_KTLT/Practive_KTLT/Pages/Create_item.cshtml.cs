using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practive_KTLT.Service;

namespace Practive_KTLT.Pages;

public class Create_item : PageModel
{
    public string text;
    [BindProperty]
    public string Item_Id { get; set; }
    [BindProperty]
    public string Item_Name { get; set; }
    [BindProperty]
    public int Item_Qty { get; set; }
    [BindProperty]
    public DateTime Item_Exp { get; set; }
    [BindProperty]
    public DateTime Item_Mfg { get; set; }
    [BindProperty]
    public string Item_Type { get; set; }
    [BindProperty]
    public float Item_Price { get; set; }
    

    public void OnGet()
    {
        text = string.Empty;
    }

    public void OnPost()
    {
        Item product ;
        product.Name = Item_Name;
        product.Id = Item_Id;
        product.Exp = Item_Exp;
        product.Mfg = Item_Mfg;
        product.Qty = Item_Qty;
        product.Price = Item_Price;
        product.Type = Item_Type;
        bool result =SolvingItem.CreateItem(product);
        text = $"input data {result}";
    }
}