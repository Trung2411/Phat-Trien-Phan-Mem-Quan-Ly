using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace New_ProJect_MVC.Models.Entities{
    [Table("Employee")]
    
    public class Employee 
    {
        [Key]
        public string? EmployeeID { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public string? Address { get; set;}
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public required string Position { get; set; }
        [Required]
        [EmailAddress]
        
        public required string Email { get; set; }
        [DataType(DataType.Date)]

        public DateTime HireDate { get; set; }




    }
}