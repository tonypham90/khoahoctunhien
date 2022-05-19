using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practive_KTLT.Service;

namespace Practive_KTLT.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public List<Item> ResList;
    [BindProperty]
    public string Keyword { get; set; }


    public void OnGet()
    {
        ResList = new List<Item>();
    }

    public void OnPost()
    {
        Keyword = Keyword;
        ResList = SolvingItem.SearchKeyWordItems(Keyword);
    }
}