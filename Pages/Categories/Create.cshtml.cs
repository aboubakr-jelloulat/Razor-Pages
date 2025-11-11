using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages.Data;
using Razor_Pages.Models;

namespace Razor_Pages.Pages.Categories
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }
    }
}
