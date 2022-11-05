using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFruits2.Data;
using MyFruits2.Models;

namespace MyFruits2.Areas.Fruits.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly MyFruits2.Data.ApplicationDbContext _context;

        public DetailsModel(MyFruits2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Fruit Fruit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Fruits == null)
            {
                return NotFound();
            }

            var fruit = await _context.Fruits.FirstOrDefaultAsync(m => m.Id == id);
            if (fruit == null)
            {
                return NotFound();
            }
            else 
            {
                Fruit = fruit;
            }
            return Page();
        }
    }
}
