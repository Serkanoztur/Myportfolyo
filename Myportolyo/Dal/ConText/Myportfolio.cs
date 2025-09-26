using Microsoft.EntityFrameworkCore;
using Myportolyo.Dal.entites;

namespace Myportolyo.Dal.ConText
{
    public class Myportfolio : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-D33E71R\\SQLEXPRESS;initial catalog=MyPortfolioDb;integrated Security=True;TrustServerCertificate=True;");
        }
        public DbSet <About> Abouts { get; set; }
        public DbSet <Contact> Contacts { get; set; }
        public DbSet <Experience> Experiences { get; set; }
        public DbSet <feature> Features { get; set; }
        public DbSet <Message> Messages { get; set; }
        public DbSet <Portfolio> Portfolios { get; set; }
        public DbSet <Skill> Skills { get; set; }
        public DbSet <SocialMedia> socialMedias { get; set; }
        public DbSet <Testimonial> Testimonials { get; set; }
        public DbSet <ToDoList> ToDoLists { get; set; }

        








    }
}
