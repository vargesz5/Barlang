using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using barlangapplication.DTOs;
using barlangapplication.Data;

namespace barlangapplication.Pages
{
    public class DarabokModel : PageModel
    {
        private readonly barlangapplication.Data.BarlangDbContext _context;

        public DarabokModel(barlangapplication.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public IList<VarosokBarlangDTO> VarosokBarlangDTO { get;set; } = default!;

        public async Task OnGetAsync()
        {
                VarosokBarlangDTO = _context.barlangok.GroupBy(x => x.Telepules).Select(x => new VarosokBarlangDTO
                {
                    Varos = x.Key,
                    Darabszam = x.Count()
                }).ToList();
        }
    }
}
