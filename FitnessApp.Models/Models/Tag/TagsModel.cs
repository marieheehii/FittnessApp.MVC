using FitnessApp.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models.Models.Tag
{
    public class TagsModel
    {
        public int Id { get; set; }
        public virtual ICollection<Workout> Workouts { get; set; }
        public string TagValue { get; set; }
    }
}
