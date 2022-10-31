using FitnessApp.Data;
using FitnessApp.Data.Data;
using FitnessApp.Models.Models.WorkoutModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Services.WorkoutServices
{
    public class WorkoutServices : IWorkoutServices
    {
        private readonly ApplicationDbContext _context;
        public WorkoutServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddWorkoutToDB(WorkoutCreate workout)
        {
            if (workout == null)
            {
                return false;
            }
            else
            {
                   var entity = new Workout
                    {
                        Name = workout.Name,
                        MuscleGroup = workout.MuscleGroup,
                        Reps = workout.Reps,
                        Duration = workout.Duration,
                        URl = workout.URl,
                        IsPublic = workout.IsPublic,
                    };

                    _context.Workouts.Add(entity);
                    await _context.SaveChangesAsync();
                return true;
            } 

        }

        public async Task<bool> DeleteWorkout(int workoutId)
        {
            var workout = await _context.Workouts.FindAsync(workoutId);
            if (workout == null) return false;

            _context.Remove(workout);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<IEnumerable<WorkoutList>> GetAllWorkouts()
        {
            var workouts = await _context.Workouts.Select(w => new WorkoutList
            {
                Id = w.Id,
                Name = w.Name,
                MuscleGroup = w.MuscleGroup,
            }).ToListAsync();
            return workouts;
        }

        public async Task<WorkoutDetail> GetWorkout(int workoutId)
        {
            var workout = await _context.Workouts.FindAsync(workoutId);
            if (workout == null) return null;

            return new WorkoutDetail
            {
                Id = workout.Id,
                Name = workout.Name,
                MuscleGroup = workout.MuscleGroup,
                Reps = workout.Reps,
                Duration = workout.Duration,
                URl = workout.URl,
                Tags = workout.Tags,
            };
        }

        public async Task<bool> UpdateSavedWorkout(int workoutId, WorkoutEdit workout)
        {
            var searchedWorkout = await _context.Workouts.FindAsync(workoutId);
            if (workout == null) return false;

            searchedWorkout.Name = workout.Name;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
