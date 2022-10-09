using FitnessApp.Data.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Data.Data
{
    public class UserRoutine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public virtual List<SavedWorkout> AddedWorkouts { get; set; }
        public Weekday Weekday { get; set; }
        public int Duration { get; set; }
    }
}
