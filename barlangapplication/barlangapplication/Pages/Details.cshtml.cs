using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using barlangapplication.Data;
using barlangapplication.Model;

namespace barlangapplication.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly barlangapplication.Data.BarlangDbContext _context;

        public DetailsModel(barlangapplication.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public Barlang Barlang { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barlang = await _context.barlangok.FirstOrDefaultAsync(m => m.Id == id);
            if (barlang == null)
            {
                return NotFound();
            }
            else
            {
                Barlang = barlang;
            }
            return Page();
        }
    }
}
