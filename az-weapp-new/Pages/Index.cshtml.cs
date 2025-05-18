using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using az_weapp_new.Data;

namespace az_weapp_new.Pages
{
    public class IndexModel : PageModel
    {
        private readonly az_weapp_new.Data.AppDbContext _context;

        public IndexModel(az_weapp_new.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
