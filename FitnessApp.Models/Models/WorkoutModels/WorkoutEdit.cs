using FitnessApp.Data.Data;
using FitnessApp.Data.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models.Models.WorkoutModels
{
    public class WorkoutEdit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Reps { get; set; }
        [Required]
        public bool IsPublic { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
        public string URl { get; set; }
    }
}
