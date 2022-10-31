using FitnessApp.Data;
using FitnessApp.Data.Data;
using FitnessApp.Models.Models.UserRoutineModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Services.RoutineServices
{
    public class RoutineServices : IRoutineServices
    {
        private readonly ApplicationDbContext _context;
        public RoutineServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddRoutineToDB(UserRoutineCreate userRoutine)
        {
            if(userRoutine == null)
            {
                return false;
            }
            else
            {
                var entity = new UserRoutine
                {
                    Name = userRoutine.Name,
                    UserId = userRoutine.UserId,
                    WorkoutId = userRoutine.WorkoutId,
                    AddedWorkouts = userRoutine.AddedWorkouts
                };

                _context.Routines.Add(entity);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> DeleteRoutine(int routineId)
        {
            var userRoutine = await _context.Routines.FindAsync(routineId);
            if(userRoutine == null)
            {
                return false;
            }
            else
            {
                _context.Remove(userRoutine);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<IEnumerable<UserRoutineList>> GetAllRoutines()
        {
            var userRoutine = await _context.Routines.Select(r => new UserRoutineList
            {
                Name = r.Name,
                Weekday = r.Weekday,
                Id = r.Id,
            }).ToListAsync();
            return userRoutine;
        }

        public async Task<UserRoutineDetail> GetRoutine(int routineId)
        {
            var routine = await _context.Routines.FindAsync(routineId);
            if (routine == null) return null;

            return new UserRoutineDetail
            {
                Id = routine.Id,
                UserId = routine.UserId,
                Weekday =routine.Weekday,
                Name = routine.Name,
                Workout = routine.Workout,
                AddedWorkouts = routine.AddedWorkouts,
            };
        }

        public async Task<bool> UpdateRoutibe(int routineId, UserRoutineEdit userRoutine)
        {
            var searchedRoutine = await _context.Routines.FindAsync(routineId);
            if (userRoutine == null) return false;

            searchedRoutine.Name = userRoutine.Name;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
