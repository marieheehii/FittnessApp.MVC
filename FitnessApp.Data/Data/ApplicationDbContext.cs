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
        public List<Workout> Workouts { get; set; }
        public List<SavedWorkout> SavedWorkouts { get; set; }
        public List<Tags> Tagses { get; set; }
        public List<UserRoutine> Routines { get; set; }

    }
}