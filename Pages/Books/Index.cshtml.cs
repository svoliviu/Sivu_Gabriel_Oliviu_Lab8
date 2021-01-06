using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sivu_Gabriel_Oliviu_Lab8.Data;
using Sivu_Gabriel_Oliviu_Lab8.Models;

namespace Sivu_Gabriel_Oliviu_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Sivu_Gabriel_Oliviu_Lab8.Data.Sivu_Gabriel_Oliviu_Lab8Context _context;

        public IndexModel(Sivu_Gabriel_Oliviu_Lab8.Data.Sivu_Gabriel_Oliviu_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
