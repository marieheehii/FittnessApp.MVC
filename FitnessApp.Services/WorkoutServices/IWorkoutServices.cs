using FitnessApp.Models.Models.WorkoutModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Services.WorkoutServices
{
    public interface IWorkoutServices
    {
        Task<bool> AddWorkoutToDB(WorkoutCreate workout);
        Task<IEnumerable<WorkoutList>> GetAllWorkouts();
        Task<WorkoutDetail> GetWorkout(int workoutId);
        Task<bool> UpdateSavedWorkout(int workoutId, WorkoutEdit workout);
        Task<bool> DeleteWorkout(int workoutId);

    }
}
