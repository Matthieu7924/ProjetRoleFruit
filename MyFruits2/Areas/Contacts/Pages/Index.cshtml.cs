using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFruits2.Data;
using MyFruits2.Models;

namespace MyFruits2.Areas.Contacts.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyFruits2.Data.ApplicationDbContext _context;

        public IndexModel(MyFruits2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Contacts != null)
            {
                Contact = await _context.Contacts.ToListAsync();
            }
        }
    }
}
