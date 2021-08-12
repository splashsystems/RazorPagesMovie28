using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie28.Data;
using RazorPagesMovie28.Models;

namespace RazorPagesMovie28.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie28.Data.RazorPagesMovie28Context _context;

        public IndexModel(RazorPagesMovie28.Data.RazorPagesMovie28Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movie
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }
            Movie = await movies.ToListAsync();
        }
    }
}
