namespace FitnessApp.Data.Data
{
    public class Tags
    {
        public int Id { get; set; }
        public virtual ICollection<Workout> Workouts{ get; set; }
    }
}