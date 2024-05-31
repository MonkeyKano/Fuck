using System.ComponentModel.DataAnnotations;

namespace Employee_Project.Models
{
    public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public int Employee_Salary { get; set; }
        public int Employee_Age { get; set; }
        public string Profile_Img { get; set; }
    }
}
