using barlangapplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace barlangapplication.Pages
{
    public class SearchModel : PageModel
    {
        private readonly barlangapplication.Data.BarlangDbContext _dbContext;

        public SearchModel(barlangapplication.Data.BarlangDbContext context)
        {
            _dbContext = context;
        }

        public IList<Barlang> Barlangok { get; set; } = default!;
        public IList<string> Varosok { get; set; }

        [BindProperty(SupportsGet = true)]
        public string VarosNev {  get; set; }


        public async void OnGet()
        {
            Varosok = _dbContext.barlangok.Select(x => x.Telepules).Distinct().ToList();
            Barlangok = await _dbContext.barlangok.Where(x => x.Telepules == VarosNev).ToListAsync();
        }
    }
}
