using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    [Table("EmployeeEducation")]
    public class EmployeeEducation
    {

        public int EmployeeEducationID { get; set; }
        public int EmployeeID { get; set; }
        public string DegreeTitle { get; set; }
        public string TotalMarks { get; set; }
        public string ObtainedMarks { get; set; }
        public string Division { get; set; }
        public string PassingYear { get; set; }
        public string Grade { get; set; }
        public string Specialization { get; set; }
        public string Institute { get; set; }
        public string DegreeStatus { get; set; }
        public string HighestDegree { get; set; }
        

    }
}
