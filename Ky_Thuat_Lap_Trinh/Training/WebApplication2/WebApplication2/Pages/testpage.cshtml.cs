using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages;

public class testpage : PageModel
{
    public string chuoi { get; set; }
    public int love { get; set; }
    [BindProperty]
    public int x { get; set; }
    public void OnGet()
    {
        chuoi = "toila ai";
        love = 100;
    }

    public void OnPost()
    {
        love = x * 100;
    }
    
}