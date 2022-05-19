using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class CreateTaskModel : PageModel
    {
        [BindProperty]
        public Task NewTask { get; set; }
        private ApplicationDbContext _context;        
        public CreateTaskModel(ApplicationDbContext context)
        {
            this._context = context;
        }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            this._context.Add(this.NewTask);
            this._context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
