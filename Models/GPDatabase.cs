using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace GP_Project.Models
{
    public class GPDatabase : DbContext
    {
        public GPDatabase () 
        {

        }
        public virtual DbSet<Users> TbUsers { get; set; }
        public virtual DbSet<Admin> TbAdmin { get; set; }
        public virtual DbSet<Places> TbPlaces { get; set; }
        public virtual DbSet<Promocode> TbPromocode { get; set; }
        public virtual DbSet<Feedback> TbFeedback { get; set; }
        public virtual DbSet<User_Rating_Place> TbUserRating { get; set; }
        public virtual DbSet<User_Search_Place> TbUserSearchPlace { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-FIOI7RD;Database=G<---->P;Trusted_Connection=True;MultipleActiveResultSets=false;TrustServerCertificate=Yes");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Users>(entity =>
            {
                entity.
                HasOne(a => a.TbAdmin).
                WithMany(a => a.CUsers).HasForeignKey(a => a.Admin_Id);
            });
            modelBuilder.Entity<Places>(entity =>
            {
                entity.
                HasOne(a => a.TbAdmin).
                WithMany(a => a.CPlaces).HasForeignKey(a => a.Admin_Id);
            });
            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(a => a.Content).HasMaxLength(200);
                entity.
                HasOne(a => a.TbPlaces).
                WithMany(a => a.Feedbacks).HasForeignKey(a => a.Place_Id);
                entity.
                HasOne(a => a.TbUsers).
                WithMany(a => a.Feedbacks).
                HasForeignKey(a => a.User_Id).
                OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<Promocode>(entity =>
            {
                entity.
                HasOne(a => a.TbAdmin).
                WithMany(a => a.promocodes).HasForeignKey(a => a.Admin_Id);
                entity.
                HasOne(a => a.TbUsers).
                WithMany(a => a.promocodes).
                HasForeignKey(a => a.User_Id).
                OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<User_Rating_Place>(entity =>
            {
                entity.
                HasOne(a => a.TbUsers).
                WithMany(a => a.CUser_Rating).
                HasForeignKey(a => a.User_Id).
                OnDelete(DeleteBehavior.ClientSetNull);
                entity.
                HasOne(a => a.TbPlaces).
                WithMany(a => a.CUser_Rating).
                HasForeignKey(a => a.Place_Id);
            });
            modelBuilder.Entity<User_Search_Place>(entity =>
            {
                entity.
                HasOne(a => a.TbUsers).
                WithMany(a => a.CUserSearchPlace).
                HasForeignKey(a => a.User_Id).
                OnDelete(DeleteBehavior.ClientSetNull);
                entity.
                HasOne(a => a.TbPlaces).
                WithMany(a => a.CUserSearchPlace).
                HasForeignKey(a => a.Place_Id);
            });
        }
    }
}
