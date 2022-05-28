using Manage_Store.Entity;
using Manage_Store.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Manage_Store.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public List<StrucItem> ItemsinStore = SolvingItem.RequestLoadStore();
    public List<StrucItem> ItemsShow { get; set; }

    public void OnGet()
    {
        ItemsShow = ItemsinStore;
    }

    public void OnPost()
    {
        
    }
}