using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Razor_Pages.Data;
using Razor_Pages.Models;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Razor_Pages.Pages.Categories
{
    [BindProperties]

    //why BindProperties
    //    ASP.NET Core automatically looks at all public properties inside this class (like public Category Category { get; set; })
    //    and tries to fill them from the form values in the HTTP request(form, query, route, etc.).

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

        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
    }
}
