using System.ComponentModel.DataAnnotations;

namespace GP_Project.Models
{
    public class Users
    {
        public Users()
        {
            TbAdmin = new Admin();
            Feedbacks = new HashSet<Feedback>();
            promocodes = new HashSet<Promocode>();
            CUser_Rating = new HashSet<User_Rating_Place>();
            CUserSearchPlace = new HashSet<User_Search_Place>();
        }
        [Key]
        public int User_Id { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
       
        [StringLength(15, ErrorMessage = "First Name must be less than 15")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Enter Last Name")]
       
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

        [Required(ErrorMessage = "Please Enter Country")]
        
        [StringLength(5, ErrorMessage = "Country must be less than 5")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please Enter City")]
        
        [StringLength(20, ErrorMessage = "City must be less than 20")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        
        [StringLength(80, ErrorMessage = "Address must be less than 80")]
        public string Address { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public ICollection<Promocode> promocodes { get; set; }
        public ICollection<User_Rating_Place>CUser_Rating{ get; set; }
        public ICollection<User_Search_Place> CUserSearchPlace { get; set; }
        public int Admin_Id { get; set; }
        public Admin TbAdmin { get; set; }
    }
}
