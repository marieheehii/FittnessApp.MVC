using FitnessApp.Models.Models.SavedWorkouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Services.SavedWorkoutServices
{
    public interface ISavedWorkoutServices
    {
        Task<bool> AddSavedWorkoutToDB(SavedWorkoutsCreate savedWorkout);
        Task<IEnumerable<SavedWorkoutsList>> GetAllSavedWorkouts();
        Task<SavedWorkoutsDetails> GetSavedWorkout(int savedWorkoutId);
        Task<bool> UpdateSavedWorkout(int savedWorkoutId, SavedWorkoutsEdit savedWorkout);
        Task<bool> DeleteWorkout(int savedWorkoutId);
    }
}
