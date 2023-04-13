using System.ComponentModel.DataAnnotations;

namespace GP_Project.Models
{
    public class Places
    {
        public Places()
        {
            Feedbacks = new HashSet<Feedback>();
            CUser_Rating = new HashSet<User_Rating_Place>();
            CUserSearchPlace = new HashSet<User_Search_Place>();
            TbAdmin = new Admin();
        }
        [Key]
        public int Place_Id { get; set; }
        [StringLength(50, ErrorMessage = "Name of place must be less than 50")]
        public string Place_Name { get; set; }

        [StringLength(1000, ErrorMessage = "Description of place must be less than 1000")]
        public string Place_Description { get; set; }

        [StringLength(1000, ErrorMessage = "ZIP_Code of place must be less than 10")]
        public int ZIP_Code { get; set; }

        [StringLength(50, ErrorMessage = "Country  must be less than 50")]
        public string Country { get; set; }

        [StringLength(50, ErrorMessage = "City of place must be less than 50")]
        public string City { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public ICollection<User_Rating_Place> CUser_Rating { get; set; }
        public ICollection<User_Search_Place> CUserSearchPlace { get; set; }
        public int Admin_Id { get; set; }
        public Admin TbAdmin { get; set; }

    }
}
