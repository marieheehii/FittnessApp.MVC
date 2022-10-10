using FitnessApp.Models.Models.UserRoutineModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Services.RoutineServices
{
    public class RoutineServices : IRoutineServices
    {
        public Task<bool> AddRoutineToDB(UserRoutineCreate userRoutine)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRoutine(int routineId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserRoutineList>> GetAllRoutines()
        {
            throw new NotImplementedException();
        }

        public Task<UserRoutineDetail> GetRoutine(int routineId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRoutibe(int routineId, UserRoutineEdit userRoutine)
        {
            throw new NotImplementedException();
        }
    }
}
