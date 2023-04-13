using System.ComponentModel.DataAnnotations;

namespace GP_Project.Models
{
    public class Admin
    {
        public Admin()
        {
            CPlaces = new HashSet<Places>();
            promocodes = new HashSet<Promocode>();
            CUsers = new HashSet<Users>();
        }
        [Key]
        public int Admin_Id { get; set; }

        [Required(ErrorMessage = "Please Enter First Name")]
        [StringLength(15, ErrorMessage = "First Name must be less than 15")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        [StringLength(15, ErrorMessage = "Last Name must be less than 15")]
        public string Last_Name { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Please Enter Valid Email")]
        [StringLength(100, ErrorMessage = "Email must be less than 100")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [StringLength(50, ErrorMessage = "Password must be less than 50")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "password does not match")]
        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [StringLength(50, ErrorMessage = "Confirm Password must be less than 50")]
        public string Confirm_Password { get; set; }

        [StringLength(15, ErrorMessage = "DateOfBirth must be less than 15")]
        public string DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number")]
        [StringLength(11, ErrorMessage = "Please Enter must be less than 11")]
        public string PhoneNumber { get; set; }
        public ICollection<Places> CPlaces { get; set; }
        public ICollection<Promocode> promocodes { get; set; }
        public ICollection<Users> CUsers { get; set; }
    }
}
