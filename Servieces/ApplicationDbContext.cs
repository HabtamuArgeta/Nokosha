using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nokosha.Models;
using System.Reflection.Emit;

namespace Nokosha.Servieces
{
  
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext(DbContextOptions options) : base(options)
            {
            }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var Admin = new IdentityRole("Admin");
            Admin.NormalizedName = "Admin";

            var Youtuber = new IdentityRole("Youtuber");
            Youtuber.NormalizedName = "Youtuber";

            var Subscriber = new IdentityRole("Subscriber");
            Subscriber.NormalizedName = "Subscriber";


            builder.Entity<IdentityRole>().HasData(Admin, Youtuber, Subscriber);

            // This is used to fill defoult value on yearOfStudy Table 
            //builder.Entity<YearOfStudy>().HasData(
            //  new YearOfStudy { Id = 1, Year = "First Year" },
            //  new YearOfStudy { Id = 2, Year = "Second Year" },
            //  new YearOfStudy { Id = 3, Year = "Third Year" },
            //  new YearOfStudy { Id = 4, Year = "Fourth Year" },
            //  new YearOfStudy { Id = 5, Year = "Fifth Year" },
            //  new YearOfStudy { Id = 6, Year = "Sixth Year" },
            //  new YearOfStudy { Id = 7, Year = "Seventh Year" }
            //  );
            //builder.Entity<Department>().HasData(
            //  new Department { Id = 1, Name = "Defoult Department" }
            // );
            //builder.Entity<University>().HasData(
            //  new University { id = 1, name = "Defoult University" }
            // );


        }
        //public DbSet<InternshipDotCom.Models.Internship> Internship { get; set; } = default!;
        //public DbSet<InternshipDotCom.Models.Organization> Organization { get; set; } = default!;


        




    }
    }
