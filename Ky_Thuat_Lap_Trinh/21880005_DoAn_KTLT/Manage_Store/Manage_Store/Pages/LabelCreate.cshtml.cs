using Manage_Store.DAL;
using Manage_Store.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Manage_Store.Pages;

public class LabelCreate : PageModel
{
    public string Nortification { get; set; }
    public List<string> labelist { get; set; }
    [BindProperty] 
    public string NewLabel { get; set; }
    public void OnGet()
    {
        Nortification = String.Empty;
        labelist = DataWorkFlow.DownloadListLabel();
    }

    public void OnPost()
    {
        string addNewLabel = NewLabel;
        Nortification = SolvingItemLabel.AddNewLabel(addNewLabel);
        labelist = DataWorkFlow.DownloadListLabel();
    }
    
}