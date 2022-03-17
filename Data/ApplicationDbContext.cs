using Competition_PRO.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Competition_PRO.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<BestDriver> BestDrivers { get; set; }
        public DbSet<BestMechanic> BestMechanics { get; set; }
        public DbSet<Jury> Juries { get; set; }
        public DbSet<JuryMember> JuryMembers { get; set; }
        public DbSet<TeamParticipant> TeamParticipants { get; set; }
        public DbSet<TheoryTest> TheoryTests { get; set; }
        public DbSet<MechanicPrimary> MechanicPrimaries { get; set; }
        public DbSet<ApplicationRole> ApplicationRole { get; set; }

    }
}
