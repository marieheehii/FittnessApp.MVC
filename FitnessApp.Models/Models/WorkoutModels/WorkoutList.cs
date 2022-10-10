using FitnessApp.Data.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models.Models.WorkoutModels
{
    public class WorkoutList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
    }
}
