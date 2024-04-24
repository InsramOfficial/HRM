using HRMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace HRMS.Pages.Dashboard
{
    public class _DesignationModel : PageModel
    {
        DatabaseContext db;
        public Designation designation { get; set; }
        public _DesignationModel(DatabaseContext _db)
        {
            db= _db;
        }
        [HttpPost]
        public IActionResult OnPost(Designation designation)
        {
            db.designations.Add(designation);
            db.SaveChanges();
            return RedirectToPage("Dashboard/_designation");
        }
    }
}
