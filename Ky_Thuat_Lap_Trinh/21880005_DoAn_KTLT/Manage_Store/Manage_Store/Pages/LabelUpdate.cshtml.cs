using Manage_Store.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Manage_Store.Pages;

public class LabelUpdate : PageModel
{
    public string Notification { get; set; }
    [BindProperty(SupportsGet = true)]
    public string label { get; set; }
    [BindProperty]
    public string newLabel { get; set; }
    public void OnGet()
    {
        Notification=String.Empty;
        newLabel = String.Empty;
    }

    public void OnPost()
    {
        Notification = SolvingItemLabel.UpdateLabel(label, newLabel);
    }
}