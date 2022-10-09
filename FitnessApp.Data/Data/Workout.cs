using FitnessApp.Data.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Data.Data
{
    public class Workout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Reps { get; set; }
        public bool IsPublic { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
        public string URl { get; set; }

    }
}
