using FitnessApp.Data.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<SavedWorkout> SavedWorkouts { get; set; }
        public DbSet<Tags> Tagses { get; set; }
        public DbSet<UserRoutine> Routines { get; set; }

    }
}