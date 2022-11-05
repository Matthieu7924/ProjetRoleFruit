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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext ctx;

        public IndexModel(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IList<Fruit> Fruit { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (ctx.Fruits != null)
            {
                Fruit = await ctx.Fruits.Include(f=>f.Image).ToListAsync();
            }
        }
    }
}
