using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarApp.Data;
using CarApp.Data.DomainModels;

namespace CarApp.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly CarAppDbContext _context;

        public IndexModel(CarAppDbContext context)
        {
            _context = context;
        }

        public IList<Car> Cars { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cars != null)
            {
                Cars = await _context.Cars.ToListAsync();
            }
        }
    }
}

