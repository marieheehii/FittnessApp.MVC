using FitnessApp.Data.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models.Models.UserRoutineModels
{
    public class UserRoutineList
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Weekday Weekday { get; set; }
    }
}
