using System.ComponentModel.DataAnnotations;

namespace GP_Project.Models
{
    public class Feedback
    {
        public Feedback()
        {
            TbPlaces = new Places();
            TbUsers = new Users();
        }
        [Key]
        public int Feedback_Id { get; set; }
        public string Content { get; set; }
        public DateTime DateRecorded { get; set; }
        public int Place_Id { get; set; }
        public Places TbPlaces { get; set; }
        public int User_Id { get; set; }
        public Users TbUsers { get; set; }
    }
}
