﻿using System.ComponentModel.DataAnnotations;

namespace GP_Project.Models
{
    public class User_Search_Place
    {
        public User_Search_Place()
        {
            TbUsers = new Users();
            TbPlaces = new Places();
        }
        [Key]
        public int User_Search_Place_Id { get; set; }
        public int User_Id { get; set; }
        public int Place_Id { get; set; }
        public Users TbUsers { get; set; }
        public Places TbPlaces { get; set; }
    }
}
