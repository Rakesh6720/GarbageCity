using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GarbageCity.Models;

namespace GarbageCity.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly GarbageCity.Models.CompanyContext _context;

        public IndexModel(GarbageCity.Models.CompanyContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
