using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ioia_Andrei_Lab2.Data;
using Nume_Pren_Lab2.Models;

namespace Ioia_Andrei_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Ioia_Andrei_Lab2.Data.Ioia_Andrei_Lab2Context _context;

        public IndexModel(Ioia_Andrei_Lab2.Data.Ioia_Andrei_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
