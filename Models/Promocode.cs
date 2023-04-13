using System.ComponentModel.DataAnnotations;

namespace GP_Project.Models
{
    public class Promocode
    {
        public Promocode()
        {
            TbAdmin = new Admin();
            TbUsers = new Users();
        }
        [Key]
        public int promocode_Id { get; set; }
        public int Admin_Id { get; set; }
        public Admin TbAdmin { get; set; }
        public int User_Id { get; set; }
        public Users TbUsers { get; set; }

    }
}
