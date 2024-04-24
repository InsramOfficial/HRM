using HRMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRMS.Pages.Dashboard
{

   
    public class DepartementModel : PageModel
    {
        DatabaseContext db;
        public Departemement Departemement { get; set; }
        public DepartementModel(DatabaseContext _db)
        {
            db= _db;
        }
        [HttpPost]
        public IActionResult OnPost(Departemement departemement)
        {
            db.departemements.Add(departemement);
            db.SaveChanges();
            return RedirectToPage("/Dashboard/Departement");
        }
    }
}
