using FitnessApp.Models.Models.UserRoutineModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Services.RoutineServices
{
    public interface IRoutineServices
    {
        Task<bool> AddRoutineToDB(UserRoutineCreate userRoutine);
        Task<IEnumerable<UserRoutineList>> GetAllRoutines();
        Task<UserRoutineDetail> GetRoutine(int routineId);
        Task<bool> UpdateRoutibe(int routineId, UserRoutineEdit userRoutine);
        Task<bool> DeleteRoutine(int routineId);
    }
}
