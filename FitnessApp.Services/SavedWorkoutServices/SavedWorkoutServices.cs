using FitnessApp.Data;
using FitnessApp.Data.Data;
using FitnessApp.Models.Models.SavedWorkouts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Services.SavedWorkoutServices
{
    public class SavedWorkoutServices : ISavedWorkoutServices
    {
        private readonly ApplicationDbContext _context;
        public SavedWorkoutServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddSavedWorkoutToDB(SavedWorkoutsCreate savedWorkout)
        {
            if(savedWorkout == null)
            {
                return false;
            }
            else
            {
                var entity = new SavedWorkout
                {
                    Comments = savedWorkout.Comments
                };

                _context.SavedWorkouts.Add(entity);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> DeleteWorkout(int savedWorkoutId)
        {
            var savedWorkout = await _context.SavedWorkouts.FindAsync(savedWorkoutId);
            if (savedWorkout == null) return false;

            _context.Remove(savedWorkout);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<SavedWorkoutsList>> GetAllSavedWorkouts()
        {
            var savedWorkouts = await _context.SavedWorkouts.Select(w => new SavedWorkoutsList
            {
                Comments = w.Comments,

            }).ToListAsync();
            return savedWorkouts;
        }

        public async Task<SavedWorkoutsDetails> GetSavedWorkout(int savedWorkoutId)
        {
            var savedWorkout = await _context.SavedWorkouts.FindAsync(savedWorkoutId);
            if (savedWorkout == null) return null;

            return new SavedWorkoutsDetails
            {
                Comments = savedWorkout.Comments,
            };
        }

        public async Task<bool> UpdateSavedWorkout(int savedWorkoutId, SavedWorkoutsEdit savedWorkout)
        {
            var searchedSavedWorkout = await _context.SavedWorkouts.FindAsync(savedWorkoutId);
            if (savedWorkout == null) return false;

            searchedSavedWorkout.Comments = savedWorkout.Comments;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
