using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages.Data;
using Razor_Pages.Models;

namespace Razor_Pages.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category? Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int? id)
        {
            if (id is null or 0)
            {
                return ;
            }
            Category = _db.Categories.Find(id);
        }

        public IActionResult OnPost()
        {
            Category? category_to_delete = _db.Categories.Find(Category.Id);

            if (category_to_delete is null)
                return NotFound();

            _db.Categories.Remove(category_to_delete);

            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully!";

            return RedirectToPage("Index");
        }
    }
}
