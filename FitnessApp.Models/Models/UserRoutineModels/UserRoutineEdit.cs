using FitnessApp.Data.Data;
using FitnessApp.Data.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models.Models.UserRoutineModels
{
    public class UserRoutineEdit
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        [Required]
        [ForeignKey(nameof(Workout))]
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public virtual List<SavedWorkout> AddedWorkouts { get; set; }
        public Weekday Weekday { get; set; }
    }
}
