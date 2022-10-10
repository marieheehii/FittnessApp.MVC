using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models.Models.SavedWorkouts
{
    public class SavedWorkoutsList
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }

        public string Comments { get; set; }
    }
}
