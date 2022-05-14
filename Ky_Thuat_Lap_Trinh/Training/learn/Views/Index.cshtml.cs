#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using learn.Data;
using learn.Models;

namespace learn.Views
{
    public class IndexModel : PageModel
    {
        private readonly learn.Data.ApplicationDbContext _context;

        public IndexModel(learn.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Joke> Joke { get;set; }

        public async Task OnGetAsync()
        {
            Joke = await _context.Joke.ToListAsync();
        }
    }
}
