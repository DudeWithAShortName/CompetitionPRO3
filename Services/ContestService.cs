using Competition_PRO.Data;
using Competition_PRO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Services
{
    public class ContestService : IContestService
    {
        private readonly ApplicationDbContext db;
        private enum Role { mechanic1, mechanic2, driver, leader };
        public ContestService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<ListovkiInputModel> GetAllParticipants()
        {
            var participants = this.db.TeamParticipants
                 .Select(x => new ListovkiInputModel
                 {
                     ParticipantNumber = x.Number,
                     Name = x.Name,
                     SchoolName = x.Team.ShortName
                 }).ToList();
            return participants;
        }
          public IEnumerable<ParticipantInputModel> GetTeamMechanics(int TeamNumber)
          {
              var model = this.db.TeamParticipants.Where(x =>
                      (x.Team.Number == TeamNumber) &&
                      (x.Role == (int)Role.mechanic1 || x.Role == (int)Role.mechanic2))
                  .Select(x => new ParticipantInputModel
                  {
                      Id = x.Id,
                      Name = x.Name,
                      Number = x.Number,
                    //  Points = GetParticipantPoints(x.Id)
                  }).ToList();
              return model;
          }
        /*public IEnumerable<ParticipantInputModel> GetTeamMechanics(int TeamNumber)
        {
            var model = this.db.MechanicPrimaries
        }*/
        public string PointsToString(IEnumerable<int> pointsArr)
        {
            return string.Join(" ", pointsArr);
        }
        public IEnumerable<int> PointToArrInt(string points)
        {
            return points.Split(' ').Select(int.Parse).ToArray();
        }
        /*public static IEnumerable<int> GetParticipantPoints(int id)
        {
            var model = this.db.MechanicPrimaries.Where(x => x.Id == id)
                .Select(x => new ParticipantInputModel
                {
                    Points = PointToArrInt(x.Points)
                }).FirstOrDefault();
            return model.Points;
        }*/
    }
}
