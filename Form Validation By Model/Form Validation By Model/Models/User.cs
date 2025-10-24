using System.ComponentModel.DataAnnotations;
namespace Form_Validation_By_Model.Models
   
{
    public class User
    {
        [Required(ErrorMessage ="name must be required")]
        [MinLength(3, ErrorMessage = "minimum length is 3")]
        [MaxLength(30, ErrorMessage = "maximum length is 30")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Phone is required")]
        [Phone]
        
        public string Phone { get; set; }


        [Required(ErrorMessage = "age must be required")]
        [Range(18,45)]
        public int Age { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",
            ErrorMessage = "Password must have 8 chars, 1 upper, 1 lower, 1 number, 1 special char")]


        public string Password { get; set; }



        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Course selection required")]
        public Courses course { get; set; }



        }
        public enum Courses
        {
            adse, hdse, stc
        }
    }

