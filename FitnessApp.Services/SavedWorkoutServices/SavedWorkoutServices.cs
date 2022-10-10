using FitnessApp.Models.Models.SavedWorkouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Services.SavedWorkoutServices
{
    public class SavedWorkoutServices : ISavedWorkoutServices
    {
        public Task<bool> AddSavedWorkoutToDB(SavedWorkoutsCreate savedWorkout)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteWorkout(int savedWorkoutId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SavedWorkoutsList>> GetAllSavedWorkouts()
        {
            throw new NotImplementedException();
        }

        public Task<SavedWorkoutsDetails> GetSavedWorkout(int savedWorkoutId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSavedWorkout(int savedWorkoutId, SavedWorkoutsEdit savedWorkout)
        {
            throw new NotImplementedException();
        }
    }
}
