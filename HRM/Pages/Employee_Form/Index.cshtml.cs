using HRMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRMS.Pages.Employee_Form
{
    public class IndexModel : PageModel
    {
        public List<Employee> companies1 { get; set; }
        public List<Departemement> d { get; set; }
        public List<Designation> des { get; set; }
        public List<EmployeeEducation> E { get; set; }
        public List<Country> c { get; set; }
        public List<Religion> r { get; set; }
        private DatabaseContext db;

        public IndexModel(DatabaseContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {

            d = db.departemements.ToList();
            des= db.designations.ToList();
            c = db.countries.ToList();
            r = db.religions.ToList();

        }


        public IActionResult OnPostCreate(int Country_id, int designation_id, int dep_id, string Name, string Father_Name, string Email, string Other_Email, int Religion_id, string Gender, string Cnic, string Date_of_Birth,
            string Mobile_Number, string Other_Mobile_Number, 
            string experience, string marital_status, string domicile_district, string blood_group, string Nationality, string Passport_Number, string additional_information,string image, string DegreeTitle, string TotalMarks, string ObtainedMarks, string Division, string PassingYear, string Grade, string Specialization, string Institute, string DegreeStatus, string HighestDegree)
        {
            var U = new Employee
            {
                Name = Name,
                Country_id = Country_id,
                designation_id = designation_id,
                dep_id = dep_id,
                Father_Name = Father_Name,
                Email = Email,
                Other_Email = Other_Email,
                Religion_id = Religion_id,
                Gender = Gender,
                Cnic = Cnic,
                Date_of_Birth = Date_of_Birth,
                Mobile_Number = Mobile_Number,
                Other_Mobile_Number = Other_Mobile_Number,
                experience = experience,
                marital_status = marital_status,
                domicile_district = blood_group,
                Nationality = Nationality,
                Passport_Number = Passport_Number,
                blood_group = blood_group,
                additional_information = additional_information,
                image= image,
                    };
            var b = new EmployeeEducation
            {
                DegreeTitle=DegreeTitle,
                TotalMarks=TotalMarks,
                ObtainedMarks=ObtainedMarks,
                Division=Division,
                PassingYear=PassingYear,
                Grade=Grade,
                Specialization=Specialization,
                Institute=Institute,
                DegreeStatus=DegreeStatus,
                HighestDegree=HighestDegree,
            };
            db.employees.Add(U);
            db.empeducation.Add(b);
            db.SaveChanges();
            return RedirectToPage("Index");
        }


    }
}
