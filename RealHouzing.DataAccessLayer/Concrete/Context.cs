using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-BL96PJ9V;initial catalog=DbRealHouzingApi;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; } 
        public DbSet<Feature> Features { get; set; }
        public DbSet<OurField> OurFields { get; set; }
        public DbSet<SellRent> SellRents { get; set; }
        public DbSet<AboutUsVideo> AboutUsVideo { get; set;}
        public DbSet<PostProperty> PostProperties { get; set;}
        public DbSet<Service> Services { get; set;}
        public DbSet<Testimonial> Testimonials { get; set;}
        public DbSet<Blog> Blogs { get; set;}
        public DbSet<Subscribe> Subscribes { get; set;}
        public DbSet<AboutFeature> AboutFeatures { get; set;}
        public DbSet<CoLiving> CoLivings { get; set;}
        public DbSet<ProgressBar> ProgressBars { get; set;}
        public DbSet<MyTeam> MyTeams { get; set;}
        public DbSet<Contact> Contacts { get; set;}
        public DbSet<Message> Messages { get; set;}
        public DbSet<ServicesPostProperty> ServicesPostProperties { get; set;}
        public DbSet<Explore> Explores { get; set;}
        public DbSet<ServicesCategories> ServicesCategories { get; set;}
       
        


    }
}
