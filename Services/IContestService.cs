using Competition_PRO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Services
{
    public interface IContestService
    {
        public IEnumerable<ListovkiInputModel> GetAllParticipants();
        public IEnumerable<ParticipantInputModel> GetTeamMechanics(int TeamNumber);
        public string PointsToString(IEnumerable<int> pointsArr);
        public IEnumerable<int> PointToArrInt(string points);
    }
}
