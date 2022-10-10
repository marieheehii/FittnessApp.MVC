using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Data.Data
{
    public class SavedWorkout
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [Required]
        [ForeignKey(nameof(Workout))]
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
        [ForeignKey(nameof(UserRoutine))]
        public int RoutineId { get; set; }
        public UserRoutine UserRoutine { get; set; }
        public string Comments { get; set; }
    }
}
