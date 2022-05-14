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
    public class DetailsModel : PageModel
    {
        private readonly learn.Data.ApplicationDbContext _context;

        public DetailsModel(learn.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Joke Joke { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Joke = await _context.Joke.FirstOrDefaultAsync(m => m.Id == id);

            if (Joke == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
