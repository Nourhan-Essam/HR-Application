
using System.ComponentModel.DataAnnotations;
namespace HRAPPLICATION.Models
{
    public class Employee
    {
        //name
        [Required(ErrorMessage ="Please Enter Name.")]
        [StringLength(20,MinimumLength =3, ErrorMessage="Invalid Name")] //Max.number of letters=20, Min.number=3
        public string EmployeeName { get; set; }
        //department
        [Required(ErrorMessage ="Please Select Department.")]
        public string Department { get; set; }
        //is active
        public bool isActive { get; set; }
        //Job title
        [Required(ErrorMessage = "job title is missing")]
        [DataType(DataType.Text)]
        public string JobTitle {  get; set; }
        //Date of Birth
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        //Email
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress {  get; set; }
    }
}
